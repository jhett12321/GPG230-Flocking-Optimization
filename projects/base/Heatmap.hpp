#ifndef HEATMAP_H
#define HEATMAP_H
#include <vector>

#include "Macros.hpp"

namespace sf
{
	class Color;
	class Sprite;
	class RenderTarget;
	class Texture;
	class Image;
}

namespace FA
{
	class AgentFactory;
	class ObstacleFactory;
	class Scene;
	class AgentContactListener;
	class Config;

	/**
	App controls the window and how to set up the scene
	*/
	class Heatmap
	{
	public:
		Heatmap();
		~Heatmap();

		void DrawHeatmap(sf::RenderTarget& rt);
		void SaveToFile(const std::string& filename);
		float Remap(float val, float min, float max, float targetMin, float targetMax);
		sf::Color& GetColorFromIntensity(float intensity);
		int GetMaxValue();

		std::vector<int> mPosFrequency;

	private:
		sf::Sprite* mSprite;
		sf::Texture* mTexture;
		sf::Image* mTexData;

		int mIntensityMultiplier = 75;
		PUBLIC_DATA_PROPERTY(bool, DrawEnabled);
	};
}

#endif//HEATMAP_H