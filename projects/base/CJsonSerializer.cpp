#include <json/reader.h>
#include "IJsonSerializable.hpp"
#include "CJsonSerializer.hpp"

bool CJsonSerializer::Deserialize(IJsonSerializable* pObj, std::string& input)
{
	if (pObj == NULL)
		return false;

	Json::Value deserializeRoot;
	Json::Reader reader;

	if (!reader.parse(input, deserializeRoot))
		return false;

	pObj->Deserialize(deserializeRoot);

	return true;
}