#include "SFML/Graphics.hpp"
#include "cmath"
#include "kf/kf_log.h"
#include "qgf2d/system.h"
#include "qgf2d/anim.h"

#include "FlockingAgentFactory.hpp"
#include "ObstacleFactory.hpp"
#include "FlockingAgentSpecification.hpp"
#include "App.hpp"
#include "Config.hpp"

using namespace std;
using namespace qgf;
using namespace kf;
using namespace sf;

int main()
{
	// This sets the working directory to where the executable is.
	initDirectory();

	// Start the KF log system, tell it to log to the console and a file.
	Log::getDefault().addCout();
	Log::getDefault().addFile("base.log");
	kf_log("This is the base qgf2d project");

	//start the app
	FA::App::Instance().Init();

	//Configurables
	FA::Config* config = FA::App::Instance().GetConfig();

	int predatorCount = std::roundf((float)config->totalAgents * config->agentRatio);
	int preyCount = config->totalAgents - predatorCount;

	for (int i = 0; i < preyCount; ++i)
	{
		FA::App::Instance().GetAgentFactory()->Create(true);
	}

#pragma region pred
	FA::AgentFactory::Params pred;

	for (int i = 0; i < predatorCount; i++)
	{
		FA::App::Instance().GetAgentFactory()->Create(false);
	}

#pragma endregion

#pragma region rect_obs
	FA::ObstacleFactory::Params op;

	op.size = kf::Vector2f(20, 20);
	op.pos = kf::Vector2f(120, 0);
	op.rotation = 25 * DEG2RAD;
	op.type = FA::Obstacle::Type::Rect;

	FA::App::Instance().GetObstacleFactory()->Create(op);

#pragma endregion

#pragma region circ_obs
	op.pos = kf::Vector2f(230, 0);
	op.type = FA::Obstacle::Type::Circ;
	FA::App::Instance().GetObstacleFactory()->Create(op);

#pragma endregion

	//let the simulation go
	FA::App::Instance().Run();

	return 0;
}
