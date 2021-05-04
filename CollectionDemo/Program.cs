using System;
using System.Collections.Generic;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            doListDemo();
            doSetDemo();
            doQueueDemo();
        }
        private static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            //Creating List
            List<string> list = new List<string>();
            //Adding object to the list
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");

            //Iterating list elements
            foreach(var element in list)
            {
                Console.WriteLine(element);
            }
        }
        private static void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");

            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        private static void doQueueDemo()
        {
            Console.WriteLine("\nIn doQueueDemo");

            //Creating Queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("Jaishankar");
            queue.Enqueue("Raj");
            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\nIterating the queue elements:");

            //Iterating Queue elements
            foreach(var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element:" + dequeue);

            Console.WriteLine("\nIterating the queue elements after dequeue one element:");
            //Iterating Queue elements using Enumerator
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
