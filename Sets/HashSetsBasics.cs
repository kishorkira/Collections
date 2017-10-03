using System;
using System.Collections.Generic;

namespace Sets
{
    class HashSetsBasics
    {
        public static void HSMain()
        {
            var bigCities = new HashSet<string>
                                (new CustomStringEqualityComparer())
            {
                "Hyderabad","Pune","Kolkatta","Chennai"
            };
            bigCities.Add("Delhi");
            bigCities.Add("PUNE");

            foreach(var bigCity in bigCities)
                Console.WriteLine(bigCity);
        }
    }
    class CustomStringEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x.ToUpper() == y.ToUpper();
        }

        public int GetHashCode(string obj)
        {
            return obj.ToUpper().GetHashCode();
        }
    }
}
