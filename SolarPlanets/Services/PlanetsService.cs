using SolarPlanets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarPlanets.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is one of four terrestrial planets in the Solar System, and is a rocky body like Earth. It is the smallest planet in the Solar System, with an equatorial radius of 2,439.7 kilometres (1,516.0 mi). The ancients knew Mercury by different names depending on whether it was an evening star or a morning star. By about 350 BC, the ancient Greeks had realized the two stars were one. They knew the planet as Στίλβων Stilbōn, meaning \"twinkling\"."
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://www.spaceviews.de/wp-content/uploads/2020/01/MercuryTitel.png",
                    "https://www.dlr.de/dlr/Portaldata/1/Resources/bilder/portal/portal_2011_3/merkur1.jpg"
                }
            }
        };


        public static List<Planet> GetFeaturedPlanets()
        {
            var rnd = new Random();
            var randomizedPlanets = planets.OrderBy(Item => rnd.Next());

            return randomizedPlanets.Take(2).ToList();
        }
    }
}
