#include "FlockingAgentFactory.hpp"
#include "Range.hpp"
#include "App.hpp"
#include "Scene.hpp"
#include "Config.hpp"

::FA::AgentFactory::AgentFactory(b2World* w) : mPhysWorld(w)
{
	FA::Config* config = FA::App::Instance().GetConfig();

#pragma region prey
	mPreyParams = new Params();

	mPreyParams->spawnAt.SetRadius(Range(config->preyMinSpawnRad, config->preyMaxSpawnRad));
	mPreyParams->accel = Range(config->preyMinAccel, config->preyMaxAccel);
	mPreyParams->startingVel.SetRadius(Range(config->preyMinStartVel, config->preyMaxStartVel));

	mPreyParams->size = Range(config->preyMinSize, config->preyMaxSize);
	mPreyParams->mass = Range(config->preyMinMass, config->preyMaxMass);

	if (config->preyAvoidanceEnabled)
	{
		mPreyParams->spec.SetAvoidance(FA::SensorSpecification(config->preyAvoidanceMinRad,
			config->preyAvoidanceMaxRad,
			config->preyAvoidanceMinAng,
			config->preyAvoidanceMaxAng,
			config->preyAvoidanceMinInf,
			config->preyAvoidanceMaxInf));
	}

	if (config->preyGroupingEnabled)
	{
		mPreyParams->spec.SetGrouping(FA::SensorSpecification(config->preyGroupingMinRad,
			config->preyGroupingMaxRad,
			config->preyGroupingMinAng,
			config->preyGroupingMaxAng,
			config->preyGroupingMinInf,
			config->preyGroupingMaxInf));
	}

	if (config->preyHeadingEnabled)
	{
		mPreyParams->spec.SetHeading(FA::SensorSpecification(config->preyHeadingMinRad,
			config->preyHeadingMaxRad,
			config->preyHeadingMinAng,
			config->preyHeadingMaxAng,
			config->preyHeadingMinInf,
			config->preyHeadingMaxInf));
	}

	if (config->preySpeedEnabled)
	{
		mPreyParams->spec.SetSpeed(FA::SensorSpecification(config->preySpeedMinRad,
			config->preySpeedMaxRad,
			config->preySpeedMinAng,
			config->preySpeedMaxAng,
			config->preySpeedMinInf,
			config->preySpeedMaxInf));
	}

	if (config->preyFleeEnabled)
	{
		mPreyParams->spec.SetFlee(FA::SensorSpecification(config->preyFleeMinRad,
			config->preyFleeMaxRad,
			config->preyFleeMinAng,
			config->preyFleeMaxAng,
			config->preyFleeMinInf,
			config->preyFleeMaxInf));
	}
#pragma endregion

#pragma region predators
	mPredParams = new Params();

	mPredParams->spawnAt.SetRadius(Range(config->preyMinSpawnRad, config->preyMaxSpawnRad));
	mPredParams->accel = Range(config->preyMinAccel, config->preyMaxAccel);
	mPredParams->startingVel.SetRadius(Range(config->preyMinStartVel, config->preyMaxStartVel));
	mPredParams->size = Range(config->preyMinSize, config->preyMaxSize);
	mPredParams->mass = Range(config->preyMinMass, config->preyMaxMass);;

	mPredParams->isPrey = false;

	if (config->predAvoidanceEnabled)
	{
		mPredParams->spec.SetAvoidance(FA::SensorSpecification(config->predAvoidanceMinRad,
			config->predAvoidanceMaxRad,
			config->predAvoidanceMinAng,
			config->predAvoidanceMaxAng,
			config->predAvoidanceMinInf,
			config->predAvoidanceMaxInf));
	}

	if (config->predGroupingEnabled)
	{
		mPredParams->spec.SetGrouping(FA::SensorSpecification(config->predGroupingMinRad,
			config->predGroupingMaxRad,
			config->predGroupingMinAng,
			config->predGroupingMaxAng,
			config->predGroupingMinInf,
			config->predGroupingMaxInf));
	}

	if (config->predHeadingEnabled)
	{
		mPredParams->spec.SetHeading(FA::SensorSpecification(config->predHeadingMinRad,
			config->predHeadingMaxRad,
			config->predHeadingMinAng,
			config->predHeadingMaxAng,
			config->predHeadingMinInf,
			config->predHeadingMaxInf));
	}

	if (config->predSpeedEnabled)
	{
		mPredParams->spec.SetSpeed(FA::SensorSpecification(config->predSpeedMinRad,
			config->predSpeedMaxRad,
			config->predSpeedMinAng,
			config->predSpeedMaxAng,
			config->predSpeedMinInf,
			config->predSpeedMaxInf));
	}

	if (config->predFleeEnabled)
	{
		mPredParams->spec.SetFlee(FA::SensorSpecification(config->predFleeMinRad,
			config->predFleeMaxRad,
			config->predFleeMinAng,
			config->predFleeMaxAng,
			config->predFleeMinInf,
			config->predFleeMaxInf));
	}

	if (config->predChaseEnabled)
	{
		mPredParams->spec.SetChase(FA::SensorSpecification(config->predChaseMinRad,
			config->predChaseMaxRad,
			config->predChaseMinAng,
			config->predChaseMaxAng,
			config->predChaseMinInf,
			config->predChaseMaxInf));
	}
#pragma endregion
}

FA::FlockingAgent* FA::AgentFactory::Create(bool isPrey)const
{
	Params& p = *mPreyParams;

	if (!isPrey)
	{
		p = *mPredParams;
	}

	FlockingAgent* retval = new FlockingAgent();

	//generate from rands
	float size = p.size.Rand();
	float mass = p.mass.Rand();
	retval->SetSensorArray(p.spec.Generate());

	//set up dynamic body
	b2BodyDef bodyDef;
	bodyDef.type = b2_dynamicBody;
	bodyDef.position.Set(0.0f, 0.0f);
	bodyDef.fixedRotation = true;
	b2Body* body = mPhysWorld->CreateBody(&bodyDef);
	body->SetLinearDamping(0.1f);

	b2CircleShape c;
	c.m_radius = size;

	b2FixtureDef fixtureDef;
	fixtureDef.shape = &c;
	fixtureDef.density = mass / (b2_pi *size*size);
	fixtureDef.friction = 0.3f;

	body->CreateFixture(&fixtureDef);

	retval->SetBody(body);

	//make centre circle
	retval->SetCentreCircle(new sf::CircleShape(size));
	retval->GetCentreCircle()->setOrigin(size, size);

	//Start position
	FA::Config* config = FA::App::Instance().GetConfig();

	sf::Vector2u windowSize = App::Instance().GetWindow()->getSize();

	kf::Vector2f startPos;

	if (config->rndSpawn)
	{
		startPos.x = rand() % windowSize.x;
		startPos.y = rand() % windowSize.y;
	}

	else
	{
		startPos = p.spawnAt.Rand();

		startPos.x += windowSize.x / 2;
		startPos.y += windowSize.y / 2;
	}

	//set vals
	retval->SetPosition(startPos);
	retval->SetVelocity(p.startingVel.Rand());
	retval->SetMaxAccel(p.accel.Rand());
	retval->SetIsPrey(p.isPrey);

	//Add our agent
	FA::App::Instance().GetScene()->AddAgent(retval);

	//Add our "user data" to the body.
	body->SetUserData(retval);

	return retval;
}

void FA::AgentFactory::Destroy(FA::FlockingAgent* fa)const
{
	FA::App::Instance().GetScene()->EraseAgent(fa);

	//deleting body tasks fixtures with it
	mPhysWorld->DestroyBody(fa->GetBody());
	fa->SetBody(nullptr);

	//flocking agent didn't create this so we clean it up
	delete fa->GetCentreCircle();
	fa->SetCentreCircle(nullptr);

	delete fa;
}