using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets
{
    class Intersect
    {
        public static void IMain()
        {
            var bigCities = new HashSet<string>
                               (new CustomStringEqualityComparer())
            {
                "Hyderabad","USA","Kolkatta","London"
            };

            string[] bigCitiesIndia = { "Hyderabad", "Delhi", "Mumbai", "Kolkatta" };

            //inline modify original set
            Console.WriteLine("Intersect");
            bigCities.IntersectWith(bigCitiesIndia);
            foreach (var bigCity in bigCities)
                Console.WriteLine(bigCity);
           
            Console.WriteLine("----------------");

            //linq gen new set
            var newCities = bigCities.Intersect(bigCitiesIndia);
            foreach(var city in newCities)
                Console.WriteLine(city);

        }
    }
}
