#ifndef FA_SCENE_H
#define FA_SCENE_H

#include <vector>
#include "FlockingAgent.hpp"
#include "Obstacle.hpp"

//pre-dec
namespace sf{ class RenderWindow; }

namespace FA
{
	/**
		Manager that holds and updates flocking agents and obstacles
	*/
	class Scene
	{
	public:
		Scene();
		~Scene();

		void Update(float dt);

		void Render(sf::RenderWindow& rw);

		void AddAgent(FlockingAgent* fa){ mAgents.push_back(fa); }

		void EraseAgent(FlockingAgent* fa)
		{
			for (size_t i = 0; i < mAgents.size(); ++i)
			{
				if (mAgents[i] = fa)
				{
					mAgents[i] = mAgents[mAgents.size() - 1];
					mAgents.pop_back();
					break;
				}
			}
		}

		void AddObstacle(Obstacle* o){ mObstacles.push_back(o); }

		void EraseObstacle(Obstacle* o)
		{
			for (size_t i = 0; i < mObstacles.size(); ++i)
			{
				if (mObstacles[i] = o)
				{
					mObstacles[i] = mObstacles[mObstacles.size() - 1];
					mObstacles.pop_back();
					break;
				}
			}
		}

		//allows app to clean up
		void AgentListCopy(std::vector<FlockingAgent*>& out) { out = mAgents; }
		void ClearAgentList(){ mAgents.clear(); }
		void ObstacleListCopy(std::vector<Obstacle*>& out) { out = mObstacles; }
		void ClearObstacleList(){ mObstacles.clear(); }

	protected:
		std::vector<FlockingAgent*> mAgents;
		std::vector<Obstacle*> mObstacles;
	private:
		bool mHitBorder = false;
	};
}

#endif//FA_SCENE_H