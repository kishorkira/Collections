using System;
using System.Collections.Generic;

namespace LinkedListStackQueues
{
    class LinkedLists
    {
        public static void LLMain()
        {
            var names = new LinkedList<string>();
            names.AddLast("kk");
            names.AddLast("Ram DVS");
            names.AddLast("Adithya v");
            names.AddLast("srinath");

            names.Remove("kk");
            names.AddFirst("Kishor Kira");
            

            LinkedListNode<string> Adithya = names.Find("Adithya v");
            names.AddAfter(Adithya, "Ashok");
            foreach (var name in names) { Console.WriteLine(name); }
        }
    }
}
