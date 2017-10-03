using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class CompareKeys
    {
        public static void CKMain()
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>
                                (new UncasedStringEqualityComparer())
            {

                {"ABV",new PrimeMinister("Atal Bihari Vajpayee",1998) },
                {"MMS",new PrimeMinister("Manmohan singh",2004) },
                {"modi",new PrimeMinister("Narendra Modi",2013) }
            };

            Console.WriteLine(primeMinisters["mms"]);
        }
    }
    class UncasedStringEqualityComparer : IEqualityComparer<string>
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
