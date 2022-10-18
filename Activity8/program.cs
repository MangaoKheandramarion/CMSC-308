using System;
using System.Collections.Generic;

namespace HashSet
{
    class Program
    {
         public static void Main(string[] args)
        {
            HashSet<int> hash1 = new HashSet<int>();
            HashSet<int> hash2 = new HashSet<int>();
            HashSet<int> hash3 = new HashSet<int>();
            HashSet<int> hash4 = new HashSet<int>();
            HashSet<int> hash5 = new HashSet<int>();
            HashSet<int> hash6 = new HashSet<int>();
            
            int input;
            
            Console.WriteLine("====HashSet1=====");
            for (int i = 0; i < 5; i++)
                
            {
                Console.WriteLine("Element {0}: ", i);
                int num = Convert.ToInt32(Console.ReadLine());
                hash1.Add(num);
                hash3.Add(num);
                hash5.Add(num);
            }
            Console.WriteLine("====HashSet2=====");
            for (int i = 0; i < 5; i++)
            {
            Console.WriteLine("Element {0} ", i);
                int num = Convert.ToInt32(Console.ReadLine());
                hash2.Add(num);
                hash4.Add(num);
                hash6.Add(num);
            }
            Console.WriteLine("\nUNION {0}:, i");
            hash1.UnionWith(hash2);
            foreach(int item in hash1)
            {
                Console.Write(" ");
                Console.Write(item);
            }
            Console.Write("\nIntersect: ");
            hash3.IntersectWith(hash4);
            foreach (int item in hash3)
            {
                Console.Write(" ");
                Console.Write(item);
            }

            Console.Write("\nSet Difference:");
            hash5.ExceptWith(hash6);
            foreach (int item in hash5)
            {
                Console.Write(" ");
                Console.Write(item);
        }
            Console.ReadKey();
         }
    }
}
