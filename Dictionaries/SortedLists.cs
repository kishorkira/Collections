using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class SortedLists
    {
        public static void SLMain()
        {
            var primeMinisters = new SortedList<string, PrimeMinister>
                                        (new UncasedStringComparer())
            {

                {"ABV",new PrimeMinister("Atal Bihari Vajpayee",1998) },
                {"MMS",new PrimeMinister("Manmohan singh",2004) },
                {"Modi",new PrimeMinister("Narendra Modi",2013) },
                {"kk", new PrimeMinister("kishorkira", 2024)}
            };

            Console.WriteLine(primeMinisters["KK"]);

            foreach (var pm in primeMinisters)
                Console.WriteLine(pm);
        }
    }
    class UncasedStringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
              
    }
}
