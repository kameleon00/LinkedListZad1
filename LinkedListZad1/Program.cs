using System;
using System.Collections.Generic;

namespace LinkedListZad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //first, last, before, after, after
            //            last,  , first, find
            Console.WriteLine("=============================================");
            Console.WriteLine("           DODAVANJE ELEMENATA");
            Console.WriteLine("=============================================");
            LinkedList<string> android = new LinkedList<string>();

            android.AddFirst("Ice Cream SandWich");
            android.AddLast("Marshmallow");
            android.AddBefore(android.Last, "Lollipop");
            android.AddAfter(android.First, "Jelly Bean");
            android.AddAfter(android.Find("Jelly Bean"), "Kit Kat");

            foreach (var node in android)
            {
                Console.WriteLine(node);
            }
            
            Console.WriteLine("=============================================");
            Console.WriteLine("           UKLANJANJE ELEMENATA");
            Console.WriteLine("=============================================");
            android.RemoveFirst();
            android.RemoveLast();
            android.Remove("Lollipop");
            Console.WriteLine("Nakon uklanjanja elemenata");
            foreach (var node in android)
            {
                Console.WriteLine(node);
            }
        }
    }
}