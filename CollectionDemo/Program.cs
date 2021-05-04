using System;
using System.Collections.Generic;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            doListDemo();
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
    }
}
