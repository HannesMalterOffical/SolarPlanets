namespace SolarPlanets;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("", "RegularFont");
				fonts.AddFont("", "MedoiumFont");
                fonts.AddFont("", "BoldFont");
            });

		return builder.Build();
	}
}
