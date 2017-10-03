using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Dictionaries
{
    class KeyedCollections
    {

        public static void KCMain()
        {
            var primeMinisters = new PrimeMinistersByYearElectedDictionary()
            {

                new PrimeMinister("Atal Bihari Vajpayee",1998) ,
               new PrimeMinister("Manmohan singh",2004),
               new PrimeMinister("Narendra Modi",2013)
            };
            primeMinisters.Add(new PrimeMinister("kishor kira", 2019));

            var list = (IList<PrimeMinister>)primeMinisters;
            Console.WriteLine("By index "+list[3] );


            Console.WriteLine(primeMinisters[2019]);
            foreach (var pm in primeMinisters) { Console.WriteLine(pm); }
        }
    }
    class PrimeMinistersByYearElectedDictionary :
                KeyedCollection<int, PrimeMinister>
    {
        protected override int GetKeyForItem(PrimeMinister item)
        {
            return item.YearEelected;
        }
    }

}
