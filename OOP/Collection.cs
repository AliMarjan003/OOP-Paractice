using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class Collection
    {
        internal void collect()
        {
            List<int> number=new List<int>();
            int sum = 0;
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                number.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Number are:");
            for(int i = 0;i < 5; i++)
            {
                Console.WriteLine(number[i]);
                sum = sum + number[i];
            }
            Console.WriteLine("Sum is:" + sum);
            Console.WriteLine( number.Count);
            //for (int i = 0; i <=4; i++)
            //{
            //    number.Add(int.Parse(Console.ReadLine()));

            //}
            //Console.WriteLine("Numbers are:");
            //for (int i = 0; i <=4; i++)
            //{
            //    Console.WriteLine(number[i]);

            //}

        }
    }
}
