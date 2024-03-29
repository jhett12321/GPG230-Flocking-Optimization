#include "App.hpp"
#include "Config.hpp"
#include "Debug.hpp"
#include "FlockingAgentFactory.hpp"
#include "ObstacleFactory.hpp"
#include "Scene.hpp"
#include "AgentCallbackListener.hpp"
#include <fstream>
#include <sstream>
#include "CJsonSerializer.hpp"
#include "Heatmap.hpp"

const std::string WINDOW_TITLE = "Flocking Agents - ";

FA::App& FA::App::Instance()
{
	static App app;
	return app;
}

bool FA::App::Init()
{
	if (mIsInit)
		return true;

	//Initialize and set up configuration instance.
	mConfig = new FA::Config();

	std::ifstream rawConfData("config.json");

	std::string confData;
	if (rawConfData.good())
	{
		std::stringstream buffer;

		buffer << rawConfData.rdbuf();

		confData = buffer.str();
	}

	else
	{
		confData = "{}";
	}

	rawConfData.close();

	CJsonSerializer::Deserialize(mConfig, confData);

	//Write Render options to member variables
	mLockFrameRate = mConfig->frameRateLockEnabled;
	mLockFrameRateAmt = 1000 / mConfig->frameRateCapAmt;

	mWindowWidth = 800;
	mWindowHeight = 800;

	//create window, worlds, factories, etc.
	mWindow = new sf::RenderWindow(sf::VideoMode(mWindowWidth, mWindowHeight, 32), WINDOW_TITLE, sf::Style::Close);
	mWindow->setVerticalSyncEnabled(true);
	mHeatmap = new FA::Heatmap();
	mClock = new sf::Clock();
	mPhysWorld = new b2World(b2Vec2_zero);
	mAgentFactory = new FA::AgentFactory(mPhysWorld);
	mObstacleFactory = new FA::ObstacleFactory(mPhysWorld);
	mScene = new FA::Scene();

	mContactListener = new AgentContactListener();
	mPhysWorld->SetContactListener(mContactListener);

	mIsInit = true;
	return mIsInit;
}

void FA::App::Run()
{
	if (mIsRunning)
		return;

	mIsRunning = true;

	sf::Clock frameRateClock;

	float clientPhysInterval = mConfig->clientPhysInt;

	while (mWindow->isOpen())
	{
		// Events are things such as keys being pressed, the window closing, etc.
		// There could be several events waiting for us, so use a loop to process them all.
		sf::Event ev;
		while (mWindow->pollEvent(ev))
		{
			if ((ev.type == sf::Event::Closed) || ((ev.type == sf::Event::KeyPressed) && (ev.key.code == sf::Keyboard::Escape)))
			{
				mWindow->close();
				break;
			}

			if (ev.type == sf::Event::KeyPressed && ev.key.code == sf::Keyboard::Key::Pause)
				Debug::Instance().SetEnabled(!Debug::Instance().GetEnabled());

			if (ev.type == sf::Event::KeyPressed && ev.key.code == sf::Keyboard::Key::Insert)
				mHeatmap->SetDrawEnabled(!mHeatmap->GetDrawEnabled());
		}

		// deltaT is the amount of time that has gone by since the last frame.
		PhysicsUpdate(clientPhysInterval);
		RenderUpdate(frameRateClock);

		if (!mIsRunning)
		{
			break;
		}
	}
}

void FA::App::Exit()
{
	mIsRunning = false;
}

void FA::App::PhysicsUpdate(float deltaT)
{
	//step scene
	mScene->Update(deltaT);

	//default physics steps recommended by box2d
	mPhysWorld->Step(deltaT, 6, 2);
}

void FA::App::RenderUpdate(sf::Clock& frameRateClock)
{
	if (!mLockFrameRate || (mLockFrameRate && frameRateClock.getElapsedTime().asMilliseconds() >= mLockFrameRateAmt))
	{
		// Clear the window.
		mWindow->clear();

		//render scene
		mScene->Render(*mWindow);

		Debug::Instance().DrawAll(*mWindow);

		//Render Heatmap
		mHeatmap->DrawHeatmap(*mWindow);

		// Calling display will make the contents of the window appear on screen (before this, it was kept hidden in the back buffer).
		mWindow->display();

		//Loop through agents and add it to our existing data.
		float deltaT = roundf(1 / frameRateClock.getElapsedTime().asSeconds());
		int frames = deltaT;
		mWindow->setTitle(WINDOW_TITLE + std::to_string(frames));
		frameRateClock.restart();
	}
}

FA::App::~App()
{
	//not really needed as we're a program lifetime singleton but it's better to be sure

	//since we are taking it all down with us we could optimise this but lets be thorough

	//Save Heatmap
	mHeatmap->SaveToFile("heatmap.png");

	//get a copy
	std::vector<FlockingAgent*> agents;
	mScene->AgentListCopy(agents);
	//clear so factory destroy doesn't have to remove 1 at a time as they are ALL dying
	mScene->ClearAgentList();

	for (auto* a : agents)
		mAgentFactory->Destroy(a);

	agents.clear();

	std::vector<Obstacle*> obs;
	mScene->ObstacleListCopy(obs);
	mScene->ClearObstacleList();

	for (auto* o : obs)
		mObstacleFactory->Destroy(o);

	obs.clear();

	DELETE_NULLIFY(mScene);
	DELETE_NULLIFY(mObstacleFactory);
	DELETE_NULLIFY(mAgentFactory);
	DELETE_NULLIFY(mPhysWorld);
	DELETE_NULLIFY(mClock);
	DELETE_NULLIFY(mWindow);
}