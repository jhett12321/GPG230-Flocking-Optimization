#ifndef APP_H
#define APP_H

//HACK lazy includes
#include <SFML\Graphics.hpp>
#include <Box2D\Box2D.h>

#include "AgentCallbackListener.hpp"
#include "FlockingAgentFactory.hpp"
#include "ObstacleFactory.hpp"
#include "Macros.hpp"
#include "Scene.hpp"

namespace FA
{
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

	protected:
		RO_PTR_PROPERTY(sf::RenderWindow, Window);
		RO_PTR_PROPERTY(sf::Clock, Clock);
		RO_DATA_PROPERTY(bool, IsRunning);
		RO_DATA_PROPERTY(bool, IsInit);
		RO_PTR_PROPERTY(b2World, PhysWorld);
		RO_PTR_PROPERTY(FA::AgentFactory, AgentFactory);
		RO_PTR_PROPERTY(FA::ObstacleFactory, ObstacleFactory);
		RO_PTR_PROPERTY(FA::Scene, Scene);

		RO_PTR_PROPERTY(AgentContactListener, ContactListener);

	private:
		App() :mIsRunning(false), mIsInit(false){}
	};
}

#endif//APP_H