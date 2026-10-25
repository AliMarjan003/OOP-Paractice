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
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i <=4; i++)
            {
                number.Add(int.Parse(Console.ReadLine()));

            }
            for (int i = 0; i <=4; i++)
            {
                Console.WriteLine(number);

            }
                Console.WriteLine("Numbers are:");
        }
    }
}
