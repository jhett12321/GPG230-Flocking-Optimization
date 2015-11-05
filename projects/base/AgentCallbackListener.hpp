#include <Box2D/Dynamics/b2WorldCallbacks.h>
#include <Box2D/Dynamics/Contacts/b2Contact.h>
#include "FlockingAgent.hpp"

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
					agentA->SetIsPrey(false);
					agentB->SetIsPrey(false);
				}
			}
		}
	};
}