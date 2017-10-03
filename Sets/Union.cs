using System;
using System.Collections.Generic;

namespace Sets
{
    class Union
    {
        public static void UMain()
        {
            var bigCities = new HashSet<string>
                              (new CustomStringEqualityComparer())
            {
                "Hyderabad","USA","Kolkatta","London"
            };

            string[] bigCitiesIndia = { "Hyderabad", "Delhi", "Mumbai", "Kolkatta" };

           
            Console.WriteLine("--->Union");
            //inline modify original set
            bigCities.UnionWith(bigCitiesIndia);
            foreach (var bigCity in bigCities)
                Console.WriteLine(bigCity);
        }

    }
}
