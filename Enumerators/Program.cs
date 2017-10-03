using System;
using System.Collections.Generic;

namespace Enumerators
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomEnumerator c = new CustomEnumerator();
            foreach(var item in c)
                Console.WriteLine(item);

            List<int> list = new List<int>
            {
                1,2,3,4
            };

            DisplayItems(list);
        }

        public static void DisplayItems<T>(IEnumerable<T> collection)
        {
            using(IEnumerator<T> enumerators = collection.GetEnumerator())
            {
                bool items = enumerators.MoveNext();
                while (items)
                {
                    T item = enumerators.Current;
                    Console.WriteLine(item);
                    items = enumerators.MoveNext();
                }
            }

        }
    }
}
