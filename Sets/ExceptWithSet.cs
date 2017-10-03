using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    class ExceptWithSet
    {
        public static void EMain()
        {
            var bigCities = new HashSet<string>
                              (new CustomStringEqualityComparer())
            {
                "Hyderabad","USA","Kolkatta","London"
            };

            string[] bigCitiesIndia = { "Hyderabad", "Delhi", "Mumbai", "Kolkatta" };


            Console.WriteLine("--->ExceptWith");
            //inline modify original set
            bigCities.ExceptWith(bigCitiesIndia);
            foreach (var bigCity in bigCities)
                Console.WriteLine(bigCity);
        }
    }
}
