using System;
using BinaryTree;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree t1 = new Tree();
            t1.Add(5);
            t1.Add(1);
            t1.Add(3);
            t1.Add(2);
            t1.Add(2);
            t1.Add(4);
            t1.Add(5);
            t1.Add(8);
            t1.Delete(3);


            t1.PrintTree(t1.root);


        }
    }
}