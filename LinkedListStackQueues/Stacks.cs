using System;
using System.Collections.Generic;

namespace LinkedListStackQueues
{
    class Stacks
    {
        public static void SMain()
        {
            //last in first out
            Stack<string> books = new Stack<string>();
            books.Push("book 1");
            books.Push("book 2");
            books.Push("book 3");
            books.Push("book 4");
              
            foreach (var book in books) { Console.WriteLine(book); }

            string topItem = books.Pop();
            Console.WriteLine($"Top item : {topItem}");
            foreach (var book in books) { Console.WriteLine(book); }

            string peekItem = books.Peek();
            Console.WriteLine($"top item : {peekItem}");
            foreach (var book in books) { Console.WriteLine(book); }


        }
    }
}
