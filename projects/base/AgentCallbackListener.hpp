#ifndef AGENT_CALLBACK_LISTENER
#define AGENT_CALLBACK_LISTENER

namespace FA
{
	class AgentContactListener : public b2ContactListener
	{
	public:
		AgentContactListener() {}

		void EndContact(b2Contact* contact)
		{
			//check if contacting objects are both agents.
			void* contactA = contact->GetFixtureA()->GetBody()->GetUserData();
			void* contactB = contact->GetFixtureB()->GetBody()->GetUserData();

			if (contactA && contactB)
			{
				FA::FlockingAgent* agentA = (FA::FlockingAgent*) contactA;
				FA::FlockingAgent* agentB = (FA::FlockingAgent*) contactB;

				//If one of us is not prey (predator), we now become a predator.
				if (agentA->GetIsPrey() != agentB->GetIsPrey())
				{
					if (agentA->GetIsPrey())
					{
						agentA->Infect();
					}

					else if (agentB->GetIsPrey())
					{
						agentB->Infect();
					}
				}
			}
		}
	};
}

#endif