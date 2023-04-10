using SolarPlanets.Models;



namespace SolarPlanets.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "  Mercury",
                Subtitle = "  The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is one of four terrestrial planets in the Solar System, and is a rocky body like Earth. It is the smallest planet in the Solar System, with an equatorial radius of 2,439.7 kilometres (1,516.0 mi). The ancients knew Mercury by different names depending on whether it was an evening star or a morning star. By about 350 BC, the ancient Greeks had realized the two stars were one. They knew the planet as Στίλβων Stilbōn, meaning \"twinkling\".",
                AccentColorStart = Color.FromArgb("353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://www.spaceviews.de/wp-content/uploads/2020/01/MercuryTitel.png",
                    "https://www.dlr.de/dlr/Portaldata/1/Resources/bilder/portal/portal_2011_3/merkur1.jpg"
                }
            },

            new()
            {
                Name = "  Venus",
                Subtitle = "  The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is one of the four terrestrial planets in the Solar System, meaning that it is a rocky body like Earth. It is similar to Earth in size and mass and is often described as Earth's \"sister\" or \"twin\".",
                AccentColorStart = Color.FromArgb("#A6393B"),
                AccentColorEnd = Color.FromArgb("#D17F21"),
                Images = new()
                {
                    "https://th.bing.com/th/id/R.c15b63223bfe92947db39f2aa1ef44ec?rik=u7oObgqIDUY2EQ&riu=http%3a%2f%2fwww.brightstarastronomy.com%2fwp-content%2fuploads%2f2015%2f02%2fVenus1200.jpg&ehk=CZSQdZpKAcmANkpshmq0kDnpHSjb%2bt9KZllBF5p%2fEgk%3d&risl=&pid=ImgRaw&r=0.png",
                    "https://i0.wp.com/www.astrobitacora.com/wp-content/uploads/2018/04/venus-japon.jpg?fit=1024%2C1024&ssl=11.jpg"
                }
            },

            new()
            {
                Name = "  Earth",
                Subtitle = "  The Cradle of life",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and the only place known in the universe where life has originated and found habitability. While Earth may not contain the largest volumes of water in the Solar System, only Earth sustains liquid surface water, extending over 70.8% of the Earth with its ocean, making Earth an ocean world.",
                AccentColorStart = Color.FromArgb("#0E3D68"),
                AccentColorEnd = Color.FromArgb("#2E97C7"),
                Images = new()
                {
                    "https://th.bing.com/th/id/R.c2edd01a9be5783bdf64ea6a4dfe3e8d?rik=%2bRNpJ2PFB0htKw&riu=http%3a%2f%2feoimages.gsfc.nasa.gov%2fimages%2fimagerecords%2f36000%2f36019%2fAS8-16-2593_lrg.jpg&ehk=kVQ9QSU8gZRvJ2cFUPsu2YPNcmeiAMBZsFTXDbz12LY%3d&risl=&pid=ImgRaw&r=0.png",
                    "https://th.bing.com/th/id/R.283cd7e14c28b793d9510b97f3380e13?rik=t7Qn7gydmDE%2few&pid=ImgRaw&r=0.jpg"
                }
            },

            new()
            {
                Name = "  Mars",
                Subtitle = "  The Red planet",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet from the Sun and the second-smallest planet in the Solar System, larger only than Mercury. In the English language, Mars is named for the Roman god of war. Mars is a terrestrial planet with a thin atmosphere and has a crust primarily composed of elements similar to Earth's crust, as well as a core made of iron and nickel.",
                AccentColorStart = Color.FromArgb("#A23036"),
                AccentColorEnd = Color.FromArgb("#EB3333"),
                Images = new()
                {
                    "https://th.bing.com/th/id/R.6b2045820be78a3dfc9b0cace44e7b17?rik=Sqn3XM1IW2mfPg&pid=ImgRaw&r=0.png",
                    "https://www.bing.com/images/search?view=detailV2&ccid=W0DNjqdP&id=9E7CC921A4B6F20CF4D91CF591652155622736BC&thid=OIP.W0DNjqdP1Czby4jLuoHb_wHaHa&mediaurl=https%3a%2f%2fmars.nasa.gov%2fsystem%2fdownloadable_items%2f37019_Mars_globe_1840x1840.jpg&cdnurl=https%3a%2f%2fth.bing.com%2fth%2fid%2fR.5b40cd8ea74fd42cdbcb88cbba81dbff%3frik%3dvDYnYlUhZZH1HA%26pid%3dImgRaw%26r%3d0&exph=1840&expw=1840&q=Marss&simid=608045499908496624&FORM=IRPRST&ck=9B62B7F6F002C6E95B4DBDD4A8C0B916&selectedIndex=2&ajaxhist=0&ajaxserp=0.jpg"
                }
            },

            new()
            {
                Name = "  Jupiter",
                Subtitle = "  The Gas Giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a gas giant with a mass more than two and a half times that of all the other planets in the Solar System combined, and slightly less than one one-thousandth the mass of the Sun.",
                AccentColorStart = Color.FromArgb("#9D4A40"),
                AccentColorEnd = Color.FromArgb("#CD8026"),
                Images = new()
                {
                    "https://th.bing.com/th/id/R.857637c2cb4558415c18b63d2071a4eb?rik=jRSKZGJqK9c3bg&riu=http%3a%2f%2fwww.nasa.gov%2fcenters%2fgoddard%2fimages%2fcontent%2f381775main_LARGEST_jupiter_sphere_946-710.jpg&ehk=V6f1yFJA0AxALdPd1NHtr4Is9ewt1Ipe584SmDAtyCs%3d&risl=&pid=ImgRaw&r=0.png",
                    "https://th.bing.com/th/id/R.9cdca3bacea22289dd56cbade86d564d?rik=e0jaUr6nD1uSzQ&riu=http%3a%2f%2fwww.nasa.gov%2fsites%2fdefault%2ffiles%2fthumbnails%2fimage%2fpia22424.jpg&ehk=mF20U3PIC%2bOG3DY6aw3Q9JP9YsS8MmGrZ2AyXsrPli4%3d&risl=&pid=ImgRaw&r=0.jpg"
                }
            },

             new()
            {
                Name = "  Saturn",
                Subtitle = "  The ringed planet",
                HeroImage = "satrun.png",
                Description = "Saturn is the sixth planet from the Sun and the second-largest in the Solar System, after Jupiter. It is a gas giant with an average radius of about nine and a half times that of Earth. It has only one-eighth the average density of Earth, but is over 95 times more massive.\r\nSaturn's interior is most likely composed of a rocky core, surrounded by a deep layer of metallic hydrogen, an intermediate layer of liquid hydrogen and liquid helium",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#C6502F"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/d/d2/Saturn_-_High_Resolution%2C_2004.jpg",
                    "https://d.wpimg.pl/1598483158--462283658/saturn.jpg"
                }
            },

             new()
            {
                Name = "  Uranus",
                Subtitle = "  The cold ball",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. It is named after Greek sky deity Uranus (Caelus)",
                AccentColorStart = Color.FromArgb("#9D4A40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://3c1703fe8d.site.internapcdn.net/newman/gfx/news/hires/2016/uranus.jpg",
                    "https://th.bing.com/th/id/R.99754c5c393d29e1fe1264e6cd34df92?rik=puoEneDHeVfLKA&riu=http%3a%2f%2fnssdc.gsfc.nasa.gov%2fimage%2fplanetary%2fneptune%2fneptune_false.jpg&ehk=sTVs%2bhv6bqq5lycHQOplNTppTS6Oh578yKPPhinWSLw%3d&risl=&pid=ImgRaw&r=0.jpg"
                }
            },

             new()
            {
                Name = "  Neptune",
                Subtitle = "  The god of sea",
                HeroImage = "neptune.png",
                Description = "",
                AccentColorStart = Color.FromArgb("#0C293D"),
                AccentColorEnd = Color.FromArgb("#26ABE0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/6/63/Neptune_-_Voyager_2_(29347980845)_flatten_crop.jpg",
                    "https://th.bing.com/th/id/R.39fee3811d278d337b4d258607d4949c?rik=8nBu7uGjc0qvEg&riu=http%3a%2f%2fwww.outerspaceuniverse.org%2fwp-content%2fuploads%2furanus1.jpg&ehk=7iyynP3L4myeRFhGkDMzq2pu%2fSHii2boK6qUG%2bMkECQ%3d&risl=&pid=ImgRaw&r=0.jpg"
                }
            },
        };

        public static List<Planet> GetAllPlanets() 
            => planets;


        public static List<Planet> GetFeaturedPlanets()
        {
            var rnd = new Random();
            var randomizedPlanets = planets.OrderBy(Item => rnd.Next());

            return randomizedPlanets.Take(2).ToList();
        }
    }
}
