using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace OOP
{
    internal class hash
    {
        internal void hashcheck()
        {
            //HashSet<int> number = new HashSet<int>();
            //for (int i = 0; i<5; i++)
            //{
            //    int num=int.Parse(Console.ReadLine());
            //    number.Add(num);
            //}
            //Console.WriteLine("Unique Numbers:");
            //for (int i = 0;i<number.Count; i++)
            //{
            //    Console.WriteLine(number.ElementAt(i));
            //}
            ////if (number.Contains(30))
            ////{
            ////    Console.WriteLine("Number exists");
            ////}
            //Console.WriteLine("Enter number to search:");
            //int search=int.Parse(Console.ReadLine());
            //if (number.Contains(search))
            //{
            //    Console.WriteLine("Number exists");
            //}
            //Console.WriteLine("Total Unique numbers:"+number.Count);
            //HashSet<int> set1=new HashSet<int>();
            //HashSet<int> set2=new HashSet<int>();
            //Console.WriteLine("Enter values for set1:");
            //for (int i = 0; i < 4; i++)
            //{
            //    int num=int.Parse(Console.ReadLine());
            //    set1.Add(num);
            //}
            //Console.WriteLine("Enter values for set1:");
            //for (int i = 0; i < 4; i++)
            //{
            //    int num=int.Parse(Console.ReadLine());
            //    set2.Add(num);
            //}
            //set1.UnionWith(set2);
            //for (int i = 0;i < set1.Count; i++)
            //{
            //    Console.WriteLine("Unique value is:"+set1.ElementAt(i));
            //}
            //Console.WriteLine("Total Unique values are:"+set1.Count);
            HashSet<int> set1=new HashSet<int>();
            HashSet<int> set2=new HashSet<int>();
            Console.WriteLine("Enter values for set1:");
            for (int i = 0; i < 4; i++)
            {
                int num=int.Parse(Console.ReadLine());
                set1.Add(num);
            }
            Console.WriteLine("Enter values for set2:");
            for (int i = 0; i < 4; i++)
            {
                int num=int.Parse(Console.ReadLine());
                set2.Add(num);
            }
            set1.IntersectWith(set2);
            for (int i = 0;i < set1.Count; i++)
            {
                Console.WriteLine("Unique value is:"+set1.ElementAt(i));
            }
            Console.WriteLine("Total Unique values are:"+set1.Count);
        }
    }
}