using System;
using ListyDwukierunkowe;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List l1 = new List();
            l1.AddFirst(5); // 5
            l1.AddFirst(4); // 4 5
            l1.AddFirst(4); // 4 4 5
            l1.AddLast(7);  // 4 4 5 7
            l1.AddLast(2);  // 4 4 5 7 2
            l1.AddLast(6);  // 4 4 5 7 2 6 

            l1.RemoveLast();  // 4 4 5 7 2
            l1.RemoveFirst(); // 4 5 7 2

            Console.Write(l1.Get(1).ToString() + '\n'); // 5
            Console.WriteLine(l1.NodeToString()); 
        }
    }
}