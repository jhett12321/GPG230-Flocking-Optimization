#include <json/value.h>

#include "Config.hpp"

void FA::Config::Deserialize(Json::Value& root)
{
	#pragma region General Agent Options
	totalAgents = root.get("totalAgents", 100).asInt();
	agentRatio = root.get("agentRatio", 0.03).asFloat();
	rndSpawn = root.get("rndSpawn", false).asBool();
	#pragma endregion

	#pragma region Prey Options
	preyMaxSpawnRad = root.get("preyMaxSpawnRad", 30.0).asFloat();
	preyMinSpawnRad = root.get("preyMinSpawnRad", 0.0).asFloat();
	preyMaxMass = root.get("preyMaxMass", 4.0).asFloat();
	preyMinMass = root.get("preyMinMass", 4.0).asFloat();
	preyMaxSize = root.get("preyMaxSize", 1.0).asFloat();
	preyMinSize = root.get("preyMinSize", 1.0).asFloat();
	preyMaxStartVel = root.get("preyMaxStartVel", 2.0).asFloat();
	preyMinStartVel = root.get("preyMinStartVel", -2.0).asFloat();
	preyMaxAccel = root.get("preyMaxAccel", 1000.0).asFloat();
	preyMinAccel = root.get("preyMinAccel", 500.0).asFloat();
	#pragma endregion

	#pragma region Predator Options
	predMaxSpawnRad = root.get("predMaxSpawnRad", 30.0).asFloat();
	predMinSpawnRad = root.get("predMinSpawnRad", 0.0).asFloat();
	predMaxMass = root.get("predMaxMass", 4.0).asFloat();
	predMinMass = root.get("predMinMass", 4.0).asFloat();
	predMaxSize = root.get("predMaxSize", 1.0).asFloat();
	predMinSize = root.get("predMinSize", 1.0).asFloat();
	predMaxVel = root.get("predMaxVel", 2.0).asFloat();
	predMinVel = root.get("predMinVel", -2.0).asFloat();
	predMaxAccel = root.get("predMaxAccel", 1000.0).asFloat();
	predMinAccel = root.get("predMinAccel", 500.0).asFloat();
	#pragma endregion

	#pragma region Prey Behaviours
	preyFleeMaxInf = root.get("preyFleeMaxInf", 220.0).asFloat();
	preyFleeMinInf = root.get("preyFleeMinInf", 220.0).asFloat();
	preyFleeMaxAng = root.get("preyFleeMaxAng", 180.0).asFloat();
	preyFleeMinAng = root.get("preyFleeMinAng", 180.0).asFloat();
	preyFleeMaxRad = root.get("preyFleeMaxRad", 40.0).asFloat();
	preyFleeMinRad = root.get("preyFleeMinRad", 40.0).asFloat();
	preyFleeEnabled = root.get("preyFleeEnabled", true).asBool();

	preySpeedMaxInf = root.get("preySpeedMaxInf", 20.0).asFloat();
	preySpeedMinInf = root.get("preySpeedMinInf", 20.0).asFloat();
	preySpeedMaxAng = root.get("preySpeedMaxAng", 70.0).asFloat();
	preySpeedMinAng = root.get("preySpeedMinAng", 70.0).asFloat();
	preySpeedMaxRad = root.get("preySpeedMaxRad", 40.0).asFloat();
	preySpeedMinRad = root.get("preySpeedMinRad", 40.0).asFloat();
	preySpeedEnabled = root.get("preySpeedEnabled", true).asBool();

	preyHeadingMaxInf = root.get("preyHeadingMaxInf", 50.0).asFloat();
	preyHeadingMinInf = root.get("preyHeadingMinInf", 50.0).asFloat();
	preyHeadingMaxAng = root.get("preyHeadingMaxAng", 90.0).asFloat();
	preyHeadingMinAng = root.get("preyHeadingMinAng", 90.0).asFloat();
	preyHeadingMaxRad = root.get("preyHeadingMaxRad", 30.0).asFloat();
	preyHeadingMinRad = root.get("preyHeadingMinRad", 30.0).asFloat();
	preyHeadingEnabled = root.get("preyHeadingEnabled", true).asBool();

	preyGroupingMaxInf = root.get("preyGroupingMaxInf", 50.0).asFloat();
	preyGroupingMinInf = root.get("preyGroupingMinInf", 50.0).asFloat();
	preyGroupingMaxAng = root.get("preyGroupingMaxAng", 120.0).asFloat();
	preyGroupingMinAng = root.get("preyGroupingMinAng", 120.0).asFloat();
	preyGroupingMaxRad = root.get("preyGroupingMaxRad", 50.0).asFloat();
	preyGroupingMinRad = root.get("preyGroupingMinRad", 50.0).asFloat();
	preyGroupingEnabled = root.get("preyGroupingEnabled", true).asBool();

	preyAvoidanceMaxInf = root.get("preyAvoidanceMaxInf", 80.0).asFloat();
	preyAvoidanceMinInf = root.get("preyAvoidanceMinInf", 80.0).asFloat();
	preyAvoidanceMaxAng = root.get("preyAvoidanceMaxAng", 180.0).asFloat();
	preyAvoidanceMinAng = root.get("preyAvoidanceMinAng", 180.0).asFloat();
	preyAvoidanceMaxRad = root.get("preyAvoidanceMaxRad", 25.0).asFloat();
	preyAvoidanceMinRad = root.get("preyAvoidanceMinRad", 25.0).asFloat();
	preyAvoidanceEnabled = root.get("preyAvoidanceEnabled", true).asBool();
	#pragma endregion

	#pragma region Predator Behaviours
	predChaseMaxInf = root.get("predChaseMaxInf", 1000.0).asFloat();
	predChaseMinInf = root.get("predChaseMinInf", 1000.0).asFloat();
	predChaseMaxAng = root.get("predChaseMaxAng", 90.0).asFloat();
	predChaseMinAng = root.get("predChaseMinAng", 90.0).asFloat();
	predChaseMaxRad = root.get("predChaseMaxRad", 240.0).asFloat();
	predChaseMinRad = root.get("predChaseMinRad", 240.0).asFloat();
	predChaseEnabled = root.get("predChaseEnabled", true).asBool();

	predFleeMaxInf = root.get("predFleeMaxInf", 220.0).asFloat();
	predFleeMinInf = root.get("predFleeMinInf", 220.0).asFloat();
	predFleeMaxAng = root.get("predFleeMaxAng", 180.0).asFloat();
	predFleeMinAng = root.get("predFleeMinAng", 180.0).asFloat();
	predFleeMaxRad = root.get("predFleeMaxRad", 40.0).asFloat();
	predFleeMinRad = root.get("predFleeMinRad", 40.0).asFloat();
	predFleeEnabled = root.get("predFleeEnabled", true).asBool();

	predSpeedMaxInf = root.get("predSpeedMaxInf", 20.0).asFloat();
	predSpeedMinInf = root.get("predSpeedMinInf", 20.0).asFloat();
	predSpeedMaxAng = root.get("predSpeedMaxAng", 70.0).asFloat();
	predSpeedMinAng = root.get("predSpeedMinAng", 70.0).asFloat();
	predSpeedMaxRad = root.get("predSpeedMaxRad", 40.0).asFloat();
	predSpeedMinRad = root.get("predSpeedMinRad", 40.0).asFloat();
	predSpeedEnabled = root.get("predSpeedEnabled", true).asBool();

	predHeadingMaxInf = root.get("predHeadingMaxInf", 50.0).asFloat();
	predHeadingMinInf = root.get("predHeadingMinInf", 50.0).asFloat();
	predHeadingMaxAng = root.get("predHeadingMaxAng", 90.0).asFloat();
	predHeadingMinAng = root.get("predHeadingMinAng", 90.0).asFloat();
	predHeadingMaxRad = root.get("predHeadingMaxRad", 30.0).asFloat();
	predHeadingMinRad = root.get("predHeadingMinRad", 30.0).asFloat();
	predHeadingEnabled = root.get("predHeadingEnabled", true).asBool();

	predGroupingMaxInf = root.get("predGroupingMaxInf", 50.0).asFloat();
	predGroupingMinInf = root.get("predGroupingMinInf", 50.0).asFloat();
	predGroupingMaxAng = root.get("predGroupingMaxAng", 120.0).asFloat();
	predGroupingMinAng = root.get("predGroupingMinAng", 120.0).asFloat();
	predGroupingMaxRad = root.get("predGroupingMaxRad", 50.0).asFloat();
	predGroupingMinRad = root.get("predGroupingMinRad", 50.0).asFloat();
	predGroupingEnabled = root.get("predGroupingEnabled", true).asBool();

	predAvoidanceMaxInf = root.get("predAvoidanceMaxInf", 80.0).asFloat();
	predAvoidanceMinInf = root.get("predAvoidanceMinInf", 80.0).asFloat();
	predAvoidanceMaxAng = root.get("predAvoidanceMaxAng", 180.0).asFloat();
	predAvoidanceMinAng = root.get("predAvoidanceMinAng", 180.0).asFloat();
	predAvoidanceMaxRad = root.get("predAvoidanceMaxRad", 25.0).asFloat();
	predAvoidanceMinRad = root.get("predAvoidanceMinRad", 25.0).asFloat();
	predAvoidanceEnabled = root.get("predAvoidanceEnabled", true).asBool();
	#pragma endregion

	#pragma region Client Options
	clientPhysInt = root.get("clientPhysInt", 0.01).asFloat();
	frameRateLockEnabled = root.get("frameRateLockEnabled", false).asBool();
	frameRateCapAmt = root.get("frameRateCapAmt", 60).asInt();
	#pragma endregion

	#pragma region Client Network
	clientConnectIP = root.get("clientConnectIP", "").asString();
	broadcastEnabled = root.get("broadcastEnabled", true).asBool();
	clientConnectPort = root.get("clientConnectPort", 1300).asUInt();
	#pragma endregion

	#pragma region Server Options
	serverMaxClients = root.get("serverMaxClients", 16).asInt();
	maxAgentsPerC = root.get("maxAgentsPerC", 10000).asInt();
	serverPhysInt = root.get("serverPhysInt", 0.01).asFloat();
	#pragma endregion

	#pragma region Server Network
	serverPort = root.get("serverPort", 1300).asUInt();
	#pragma endregion
}