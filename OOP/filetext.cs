using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP
{
    internal class filetext
    {
        internal void check()
        {
            string name;
            string path = "notes.txt";
            Console.WriteLine("Enter your name;");
            name = Console.ReadLine();
            File.AppendAllText(path, name + "\n");
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
