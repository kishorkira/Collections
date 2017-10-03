using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    class SymmetricExcept
    {
        public static void SEMain()
        {
            var bigCities = new HashSet<string>
                              (new CustomStringEqualityComparer())
            {
                "Hyderabad","USA","Kolkatta","London"
            };

            string[] bigCitiesIndia = { "Hyderabad", "Delhi", "Mumbai", "Kolkatta" };


            Console.WriteLine("--->SymmetricExcept");
            //inline modify original set
            bigCities.SymmetricExceptWith(bigCitiesIndia);
            foreach (var bigCity in bigCities)
                Console.WriteLine(bigCity);
        }
    }
}
