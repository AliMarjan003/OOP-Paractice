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
            string data = "student.txt";
            //string data = "check.txt",name,city;
            //Console.WriteLine("Enter your name:");
            //name = Console.ReadLine();
            //Console.WriteLine("Enter your city name:");
            //city = Console.ReadLine();
            //File.WriteAllText(data, "name is:"+ name+ " \n");
            //File.AppendAllText(data, city);
            //Console.WriteLine(File.ReadAllText(data));

            using(StreamWriter sw = new StreamWriter(data))
            {
                sw.WriteLine("Ali");
                sw.WriteLine("Marjan");
                sw.WriteLine("Iman");
            }

            //File.WriteAllText(data, "Ali Marjan\n");
            //File.AppendAllText(data, "Ahmed\n");
            //File.AppendAllText(data, "Iman\n");
            //    File.AppendAllText(data, " Welcome");
            string? data2;
            //string data2=File.ReadAllText(data);
            using (StreamReader sr = new StreamReader(data))
                {
                    while((data2 = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(data2);
                    }
                }
        }
    }
}
