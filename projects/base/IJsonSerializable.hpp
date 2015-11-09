#ifndef IJSON_SERIALIZABLE
#define IJSON_SERIALIZABLE

namespace Json
{
	class Value;
}

class IJsonSerializable
{
public:
	virtual ~IJsonSerializable(void) {};
	virtual void Deserialize(Json::Value& root) = 0;
};

#endif