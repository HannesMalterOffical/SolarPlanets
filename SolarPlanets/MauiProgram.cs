﻿namespace SolarPlanets;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Montserrat-Medium.ttf", "RegularFont");
				fonts.AddFont("Montserrat-SemiBold.ttf", "MedoiumFont");
                fonts.AddFont("Montserrat-Bold.ttf", "BoldFont");
            });

		return builder.Build();
	}
}
