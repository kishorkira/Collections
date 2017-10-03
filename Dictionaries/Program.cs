namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //CompareKeys.CKMain();
            //Console.WriteLine("---------------");

            //ReadOnlyDict.RODMain();
            //Console.WriteLine("---------------");

            //SortedLists.SLMain();
            //Console.WriteLine("---------------");

            //SortedDictionaries.SDMain();
            //Console.WriteLine("---------------");

            KeyedCollections.KCMain();

            /*
            var primeMinisters = new Dictionary<string, PrimeMinister>
            {        
                
                {"ABV",new PrimeMinister("Atal Bihari Vajpayee",1998) },
                {"MMS",new PrimeMinister("Manmohan singh",2004) },
                {"Modi",new PrimeMinister("Narendra Modi",2013) }
            };

            foreach (var pm in primeMinisters) { Console.WriteLine(pm); }

            //lookup
            PrimeMinister primeMinister;
            bool found = primeMinisters.TryGetValue("J", out primeMinister);
            string isFound = found ?primeMinister.ToString():"Not found";
            Console.WriteLine(isFound);

            //modify
            primeMinisters["Modi"] = new PrimeMinister("Modi", 2013);

            //add
            primeMinisters["j"] = new PrimeMinister("jj", 2019);
            primeMinisters.Add("kk", new PrimeMinister("kishorkira", 2024));

            //remove
            primeMinisters.Remove("Modi");
            foreach (var pm in primeMinisters) { Console.WriteLine(pm); }
            */

            
        }
    }
}
