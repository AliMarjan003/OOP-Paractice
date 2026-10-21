using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP
{
    internal class Filehande
    {
        internal void filec()
        {
        string data = "check.txt";
            File.WriteAllText(data, "Ali Marjan");
            File.AppendAllText(data, " Welcome");
            string? data2;
            //string data2=File.ReadAllText(data);
            using(StreamReader sr = new StreamReader(data))
            {
                while((data2 = sr.ReadLine()) != null)
                {
                    Console.WriteLine(data2);
                }
            }
        }
    }
}
