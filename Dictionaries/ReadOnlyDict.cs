using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Dictionaries
{
    class ReadOnlyDict
    {
        public static void RODMain()
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>
            {

                {"ABV",new PrimeMinister("Atal Bihari Vajpayee",1998) },
                {"MMS",new PrimeMinister("Manmohan singh",2004) },
                {"Modi",new PrimeMinister("Narendra Modi",2013) }
            };
            var pmsReadOnly = new ReadOnlyDictionary<string, PrimeMinister>(primeMinisters);

            foreach(var pm in pmsReadOnly)
                Console.WriteLine(pm);
        }
    }
}
