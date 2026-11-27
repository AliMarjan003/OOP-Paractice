using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class arraylist
    {
        internal void arrlistcheck()
        {
            ArrayList data=new ArrayList();
            for(int i=0;i<2; i++)
            {
                object value = Console.ReadLine();
                data.Add(value);
            }
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Array list:" + data[i]);
            }
            for(int i = 0; i < 2; i++)
            {
                data.Remove(i);
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter index:");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter value:");
                string value = Console.ReadLine();
                data.Insert(index, value);
            }
            for(int i = 0;i < 2; i++)
            {
                Console.WriteLine("Array list:" + data[i]);
            }
        }
    }
}
