using System;
using System.Collections.Generic;

namespace Sets
{
    class SortedSets
    {
        public static void SSMain()
        {
            var bigCities = new SortedSet<string>
                                (new CustomStringComparer())
            {
                "Hyderabad","Pune","Kolkatta","Chennai"
            };
            bigCities.Add("Delhi");
            bigCities.Add("PUNE");

            foreach (var bigCity in bigCities)
                Console.WriteLine(bigCity);
        }
    }
    class CustomStringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
