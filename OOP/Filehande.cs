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
            string data = "student.txt", name,name1,name2,name3;
            char choice;
            Console.WriteLine("Enter your choice:");
            choice = Convert.ToChar(Console.ReadLine());
            //string data = "check.txt", city;
            //Console.WriteLine("Enter your name:");
            //name = Console.ReadLine();
            //Console.WriteLine("Enter your name:");
            //name1 = Console.ReadLine();
            //Console.WriteLine("Enter your name:");
            //name2 = Console.ReadLine();
            //Console.WriteLine("Enter your name:");
            //name3 = Console.ReadLine();
            //Console.WriteLine("Enter your city name:");
            //city = Console.ReadLine();
            //File.WriteAllText(data, "name is:"+ name+ " \n");
            //File.AppendAllText(data, city);
            //Console.WriteLine(File.ReadAllText(data));
            if (File.Exists(data))
            {
                Console.WriteLine("File exists");
            }
            else
            {
                Console.WriteLine("File doesn't exists");
            }
            if (choice == 'y' || choice == 'Y')
            {
                File.Delete(data);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            //using (StreamWriter sw = new StreamWriter(data,true))
            //{
            //    //sw.WriteLine("1." + name);
            //    //sw.WriteLine("2." + name1);
            //    //sw.WriteLine("3." + name2);
            //    sw.WriteLine("4."+name3);
            //}

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
