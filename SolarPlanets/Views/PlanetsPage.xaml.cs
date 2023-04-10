using SolarPlanets.Models;
using SolarPlanets.Services;

public partial class PlanetsPage : ContentPage
{
	private const uint AnimationDuration = 800u;

	public PlanetsPage()
	{
		InitializeComponent();

		lstPopularPlanets.ItemSource = PlanetsService.GetFeaturedPlanets();
	}

	async void Planets_SelectionChanges(System.Object sender, System.EventArgs e)
	{
		await Navigation.PushAsync(new PlanetDetailsPage(e.CurrentSelection.First() as Planet));
	}

	async void GridArea_Tapped(System.Object sender, System.EventArgs e)
	{
		await CloseMenu();
	}

	private async Task CloseMenu()
	{
		//close emnu and show again main content
		_ = MainContentGrid.FadeTo(1, AnimationDuration);
        _ = MainContentGrid.ScaleTo(1, AnimationDuration);
        await MainContentGrid.TranslateTo(0,0, AnimationDuration, Easing.CubicIn);
    }

	async void ProfilePicture_Clicked(System.Object sender, System, EventArgs e)
	{
		_ = MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1, AnimationDuration, Easing.CubicIn);
		await MainContentGrid.ScaleTo(0.8, AnimationDuration);
		_ = MainContentGrid.FadeTo(0.8, AnimationDuration);
	}
}