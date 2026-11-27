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
            for (int i = 0; i < 5; i++)
            {
                string name=Console.ReadLine();
                data.Enqueue(name);
            }
            Console.WriteLine("Total values are:" + data.Count);
            for (int i = 0;i < 1; i++)
            {
                string removed=data.Dequeue();
                Console.WriteLine("Removed values are:"+removed);
            }
            Console.WriteLine(data.Peek());
        }
    }
}
