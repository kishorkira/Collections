using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    class SetEquals
    {
        public static void SEMain()
        {
            var bigCities = new HashSet<string>                            
            {
                "Hyderabad","USA","Kolkatta","London"
            };
            var bigCitiesAsia = new HashSet<string>
            {
                "Hyderabad","Delhi","Kolkatta","Mumbai"
            };
            string[] bigCitiesIndia = { "Hyderabad", "Delhi", "Mumbai", "Kolkatta" };


            bool cities1 = bigCities.SetEquals(bigCitiesIndia);
            Console.WriteLine($"bigcites and bigcitesindia are equal sets {cities1}");
            bool cities2 = bigCitiesAsia.SetEquals(bigCitiesIndia);
            Console.WriteLine($"bigcitesasia and bigcitesindia are equal sets {cities2}");
        }
    }
}
