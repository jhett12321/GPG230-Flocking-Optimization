#ifndef CONFIG_H
#define CONFIG_H

#include "IJsonSerializable.hpp"

namespace FA
{
	class Config : public IJsonSerializable
	{
	public:
		virtual void Deserialize(Json::Value& root);

		//Convars
		#pragma region General Agent Options
		int totalAgents;
		float agentRatio;
		bool rndSpawn;
		#pragma endregion

		#pragma region Prey Options
		float preyMaxSpawnRad;
		float preyMinSpawnRad;
		float preyMaxMass;
		float preyMinMass;
		float preyMaxSize;
		float preyMinSize;
		float preyMaxStartVel;
		float preyMinStartVel;
		float preyMaxAccel;
		float preyMinAccel;
		#pragma endregion

		#pragma region Predator Options
		float predMaxSpawnRad;
		float predMinSpawnRad;
		float predMaxMass;
		float predMinMass;
		float predMaxSize;
		float predMinSize;
		float predMaxVel;
		float predMinVel;
		float predMaxAccel;
		float predMinAccel;
		#pragma endregion

		#pragma region Prey Behaviours
		float preyFleeMaxInf;
		float preyFleeMinInf;
		float preyFleeMaxAng;
		float preyFleeMinAng;
		float preyFleeMaxRad;
		float preyFleeMinRad;
		bool preyFleeEnabled;

		float preySpeedMaxInf;
		float preySpeedMinInf;
		float preySpeedMaxAng;
		float preySpeedMinAng;
		float preySpeedMaxRad;
		float preySpeedMinRad;
		bool preySpeedEnabled;

		float preyHeadingMaxInf;
		float preyHeadingMinInf;
		float preyHeadingMaxAng;
		float preyHeadingMinAng;
		float preyHeadingMaxRad;
		float preyHeadingMinRad;
		bool preyHeadingEnabled;

		float preyGroupingMaxInf;
		float preyGroupingMinInf;
		float preyGroupingMaxAng;
		float preyGroupingMinAng;
		float preyGroupingMaxRad;
		float preyGroupingMinRad;
		bool preyGroupingEnabled;

		float preyAvoidanceMaxInf;
		float preyAvoidanceMinInf;
		float preyAvoidanceMaxAng;
		float preyAvoidanceMinAng;
		float preyAvoidanceMaxRad;
		float preyAvoidanceMinRad;
		bool preyAvoidanceEnabled;
		#pragma endregion

		#pragma region Predator Behaviours
		float predChaseMaxInf;
		float predChaseMinInf;
		float predChaseMaxAng;
		float predChaseMinAng;
		float predChaseMaxRad;
		float predChaseMinRad;
		bool predChaseEnabled;

		float predFleeMaxInf;
		float predFleeMinInf;
		float predFleeMaxAng;
		float predFleeMinAng;
		float predFleeMaxRad;
		float predFleeMinRad;
		bool predFleeEnabled;

		float predSpeedMaxInf;
		float predSpeedMinInf;
		float predSpeedMaxAng;
		float predSpeedMinAng;
		float predSpeedMaxRad;
		float predSpeedMinRad;
		bool predSpeedEnabled;

		float predHeadingMaxInf;
		float predHeadingMinInf;
		float predHeadingMaxAng;
		float predHeadingMinAng;
		float predHeadingMaxRad;
		float predHeadingMinRad;
		bool predHeadingEnabled;

		float predGroupingMaxInf;
		float predGroupingMinInf;
		float predGroupingMaxAng;
		float predGroupingMinAng;
		float predGroupingMaxRad;
		float predGroupingMinRad;
		bool predGroupingEnabled;

		float predAvoidanceMaxInf;
		float predAvoidanceMinInf;
		float predAvoidanceMaxAng;
		float predAvoidanceMinAng;
		float predAvoidanceMaxRad;
		float predAvoidanceMinRad;
		bool predAvoidanceEnabled;
		#pragma endregion

		#pragma region Client Options
		float clientPhysInt;
		bool frameRateLockEnabled;
		int frameRateCapAmt;
		int hmapIntensity;
		#pragma endregion

		#pragma region Client Network
		std::string clientConnectIP;
		bool broadcastEnabled;
		unsigned int clientConnectPort;
		#pragma endregion

		#pragma region Server Options
		int serverMaxClients;
		int maxAgentsPerC;
		float serverPhysInt;
		#pragma endregion

		#pragma region Server Network
		unsigned int serverPort;
		#pragma endregion

	};
}

#endif