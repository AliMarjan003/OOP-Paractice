using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class stack
    {
        internal void stackcheck()
        {
            Stack<string> data = new Stack<string>();
            Console.WriteLine("Enter data:");
            for (int i = 0; i < 2; i++)
            {
                string name=Console.ReadLine();
                data.Push(name);
            }
            for (int i = 0;i < 1; i++)
            {
                string name=data.Pop();
                Console.WriteLine("Popped value is:"+name);
            }
            Console.WriteLine(data.Count);
        }
    }
}
