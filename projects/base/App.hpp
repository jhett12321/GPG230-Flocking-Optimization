#ifndef APP_H
#define APP_H

#include <SFML\Graphics.hpp>

#include "Macros.hpp"

namespace sf
{
	class Clock;
}

class b2World;

namespace FA
{
	class AgentFactory;
	class ObstacleFactory;
	class Scene;
	class AgentContactListener;
	class Config;

	/**
		App controls the window and how to set up the scene
	*/
	class App
	{
	public:
		static App& Instance();
		~App();

		bool Init();

		void Run();

		void PhysicsUpdate(float deltaT);

		void RenderUpdate(sf::Clock& frameRateClock);

	protected:
		RO_PTR_PROPERTY(sf::RenderWindow, Window);
		RO_PTR_PROPERTY(sf::Clock, Clock);
		RO_PTR_PROPERTY(FA::Config, Config);
		RO_DATA_PROPERTY(bool, IsRunning);
		RO_DATA_PROPERTY(int, WindowWidth);
		RO_DATA_PROPERTY(int, WindowHeight);
		RO_DATA_PROPERTY(bool, LockFrameRate);
		RO_DATA_PROPERTY(int, LockFrameRateAmt);
		RO_DATA_PROPERTY(bool, IsInit);
		RO_PTR_PROPERTY(b2World, PhysWorld);
		RO_PTR_PROPERTY(FA::AgentFactory, AgentFactory);
		RO_PTR_PROPERTY(FA::ObstacleFactory, ObstacleFactory);
		RO_PTR_PROPERTY(FA::Scene, Scene);

		RO_PTR_PROPERTY(FA::AgentContactListener, ContactListener);

	private:
		App() :mIsRunning(false), mIsInit(false){}
	};
}

#endif//APP_H