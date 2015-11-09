#ifndef DEBUG_H
#define DEBUG_H
#include <kf/kf_vector2.h>
#include <SFML/Graphics/Color.hpp>
#include <vector>

#include "Macros.hpp"

namespace sf {
	class RenderTarget;
}

namespace FA
{
	/**
		Simple debug drawing class
	*/
	class Debug
	{
		struct LineData
		{
			LineData(const kf::Vector2f& s, const kf::Vector2f& e, const sf::Color& c) :start(s), end(e), col(c){}

			kf::Vector2f start, end;
			sf::Color col;
		};

	public:
		~Debug(){};

		static Debug& Instance();

		void DrawLine(const kf::Vector2f& start, const kf::Vector2f& end, const sf::Color& col);

		void DrawAll(sf::RenderTarget& rt);

	private:
		Debug():mEnabled(true){}
		std::vector<LineData> mLines;
		PUBLIC_DATA_PROPERTY(bool, Enabled);
	};
}

#endif//DEBUG_H