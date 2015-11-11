#include "Heatmap.hpp"
#include <SFML/Graphics/Color.hpp>
#include <SFML/Graphics/Image.hpp>
#include "App.hpp"
#include <kf/kf_math.h>
#include <iostream>

float FA::Heatmap::Remap(float val, float min, float max, float targetMin, float targetMax)
{
	float retVal = 0.0f;

	float oldRange = (max - min);
		if (oldRange == 0)
		{
			retVal = targetMin;
		}

		else
		{
			float newRange = (targetMax - targetMin);
			retVal = (((val - min) * newRange) / oldRange) + targetMin;
		}

	return retVal;
}

sf::Color& FA::Heatmap::GetColorFromIntensity(float intensity)
{
	sf::Color retVal = sf::Color();

	if (intensity > 0.8)
	{
		float colIntensity = Remap(intensity, 0.8f, 1.0f, 0.0f, 1.0f);

		retVal.r = colIntensity * 255;
		retVal.g = colIntensity * 255;
		retVal.b = colIntensity * 255;
	}

	else if (intensity > 0.64)
	{
		float colIntensity = Remap(intensity, 0.64f, 0.8f, 0.0f, 1.0f);

		retVal.r = colIntensity * 255;
		retVal.g = 0;
		retVal.b = 0;
	}

	else if (intensity > 0.48)
	{
		float colIntensity = Remap(intensity, 0.48f, 0.64f, 0.0f, 1.0f);

		retVal.r = colIntensity * 255;
		retVal.g = colIntensity * 255;
		retVal.b = 0;
	}

	else if (intensity > 0.32)
	{
		float colIntensity = Remap(intensity, 0.32f, 0.48f, 0.0f, 1.0f);

		retVal.r = 0;
		retVal.g = colIntensity * 255;
		retVal.b = 0;
	}

	else if (intensity > 0.16)
	{
		float colIntensity = Remap(intensity, 0.16f, 0.32f, 0.0f, 1.0f);

		retVal.r = 0;
		retVal.g = colIntensity * 255;
		retVal.b = colIntensity * 255;
	}

	else if (intensity > 0)
	{
		float colIntensity = Remap(intensity, 0.0f, 0.16f, 0.0f, 1.0f);

		retVal.r = 0;
		retVal.g = 0;
		retVal.b = colIntensity * 255;
	}

	return retVal;
}

int FA::Heatmap::GetMaxValue()
{
	int maxValue = 0;

	for (size_t i = 0; i < mPosFrequency.size(); ++i)
	{
		if (mPosFrequency[i] > maxValue)
		{
			maxValue = mPosFrequency[i];
		}
	}

	return maxValue;
}

FA::Heatmap::Heatmap()
{
	FA::App &appInst = FA::App::Instance();

	mTexture = new sf::Texture();
	mTexture->create(appInst.GetWindowWidth(), appInst.GetWindowHeight());

	mSprite = new sf::Sprite(*mTexture);

	mDrawEnabled = false;

	for (size_t i = 0; i < appInst.GetWindowHeight(); ++i)
	{
		for (size_t j = 0; j < appInst.GetWindowWidth(); ++j)
		{
			mPosFrequency.push_back(0);
		}
	}
}

FA::Heatmap::~Heatmap()
{
}

void FA::Heatmap::DrawHeatmap(sf::RenderTarget& rt)
{
	if (mDrawEnabled)
	{
		FA::App &appInst = FA::App::Instance();
		sf::Window* window = appInst.GetWindow();

		sf::Image texData;
		texData.create(appInst.GetWindowWidth(), appInst.GetWindowHeight(), sf::Color::Black);

		int maxValue = GetMaxValue();

		for (size_t i = 0; i < mPosFrequency.size(); ++i)
		{
			int posX = i % appInst.GetWindowWidth();
			int posY = i / appInst.GetWindowWidth();

			sf::Color outputColor = GetColorFromIntensity(kf::expose(mPosFrequency[i] / (float)maxValue * mIntensityMultiplier));

			texData.setPixel(posX, posY, outputColor);
		}

		bool test = true;

		mTexture->update(texData);

		rt.draw(*mSprite);
	}
}

void FA::Heatmap::SaveToFile(const std::string& filename)
{
	FA::App &appInst = FA::App::Instance();

	sf::Image outputFile;
	outputFile.create(appInst.GetWindowWidth(), appInst.GetWindowHeight(), sf::Color::Black);

	int maxValue = GetMaxValue();

	for (size_t i = 0; i < mPosFrequency.size(); ++i)
	{
		int posX = i % appInst.GetWindowWidth();
		int posY = i / appInst.GetWindowWidth();

		sf::Color outputColor = GetColorFromIntensity(kf::expose(mPosFrequency[i] / (float)maxValue* mIntensityMultiplier));

		outputFile.setPixel(posX, posY, outputColor);
	}

	outputFile.saveToFile(filename);
}