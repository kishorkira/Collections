using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackQueues
{
    class Queues
    {
        public static void QMain()
        {
            //first in first out
            Queue<string> tasks = new Queue<string>();
            tasks.Enqueue("buy item 1");
            tasks.Enqueue("buy item 2");
            tasks.Enqueue("buy item 3");
            tasks.Enqueue("buy item 4");
            

            foreach (var task in tasks) { Console.WriteLine(task); }
            Console.WriteLine("---------------");

            tasks.Dequeue();
            foreach (var task in tasks) { Console.WriteLine(task); }
            Console.WriteLine("---------------");


            tasks.Enqueue("buy item 5");
            foreach (var task in tasks) { Console.WriteLine(task); }
            Console.WriteLine("---------------");

            var nextTask = tasks.Peek();
            Console.WriteLine(nextTask);


        }
    }
}
