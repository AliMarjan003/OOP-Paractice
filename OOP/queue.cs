using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class queue
    {
        internal void queuecheck()
        {
            Queue<string> data = new Queue<string>();
            Console.WriteLine("Enter data:");
            for (int i = 0; i < 2; i++)
            {
                string name=Console.ReadLine();
                data.Enqueue(name);
            }
            Console.WriteLine("Total values are:" + data.Count);
            Console.WriteLine("Enter name to search");
            string search = Console.ReadLine();
            if(data.Contains(search))
            {
                Console.WriteLine("Name exists");
            }
            else
            {
                Console.WriteLine("Name doesn't exists!");
            }
            data.Clear();
            Console.WriteLine(data.Count);
            //for (int i = 0;i < 2; i++)
            //{
            //    string removed=data.Dequeue();
            //    Console.WriteLine("Removed values are:"+removed);
            //}
            //Console.WriteLine("Before Peek");
            //Console.WriteLine("First remaining value: " + data.Peek());
            //Console.WriteLine("After Peek");
        }
    }
}
