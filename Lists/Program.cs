using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollections.OCMain();


            //var names = new List<string>(6)
            var names = new List<string>
            {
                "DVS Ram",
                "Aditya",
                "Srinath"
            };

            Console.WriteLine($"Count : {names.Count} Capacity : {names.Capacity}");
            names.Add("Kishor");
            Console.WriteLine($"Count : {names.Count} Capacity : {names.Capacity}");
            names.Add("kira");
            Console.WriteLine($"Count : {names.Count} Capacity : {names.Capacity}");
           
            //index=6
            //names.RemoveAt(6);
            //removes one element that matchs input string
            //names.Remove("kira");
            foreach (var name in names) { Console.WriteLine(name); }

            //if list is big copying to array takes long
            //string[] copy = names.ToArray();
            //var copy = new ReadOnlyCollection<string>(names);
            var copy = names.AsReadOnly();

            //BadCode(copy);


            var list = new NonBlankStringList();
            list.Add("kishor");
            list[0] = "";
            list.Insert(1, "kk");
            foreach(var name in list)
                Console.WriteLine(name);

        }
        static void BadCode(IList<string> lst) => lst.RemoveAt(3);
    }
}
