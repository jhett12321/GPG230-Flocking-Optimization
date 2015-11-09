#ifndef CJSON_SERIALIZER
#define CJSON_SERIALIZER

class IJsonSerializable;

class CJsonSerializer
{
public:
	static bool Deserialize(IJsonSerializable* pObj, std::string& input);

private:
	CJsonSerializer(void) {};
};

#endif