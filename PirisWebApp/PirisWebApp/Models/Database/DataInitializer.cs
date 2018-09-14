using System;
using System.Collections.Generic;
using System.Linq;
using PirisWebApp.Models.Internal;

namespace PirisWebApp.Models.Database
{
    public static class DataInitializer
    {
        public static void Initialize(VGGContext context)
        {
            if (context.Countries.Any()) return;
            context.Countries.AddRange(new List<Country>
            {
                new Country
                {
                    Name = "Belarus"
                },
                new Country
                {
                    Name = "Russia"
                },
                new Country
                {
                    Name = "Germany"
                },
                new Country
                {
                    Name = "France"
                },
                new Country
                {
                    Name = "Italy"
                }
            });
            context.Cites.AddRange(new List<City>
            {
                new City
                {
                    Name = "Minsk"
                },
                new City
                {
                    Name = "Polotsk"
                },
                new City
                {
                    Name = "Rome"
                },
                new City
                {
                    Name =  "Moscow"
                },
                new City
                {
                    Name = "Simferopol"
                }
            });
            context.SaveChanges();
        }
    }
}