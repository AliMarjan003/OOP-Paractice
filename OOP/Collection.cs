using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OOP
{
    internal class Collection
    {
        internal void collect()
        {
            //List<int> number=new List<int>();
            //int sum = 0;
            //Console.WriteLine("Enter 5 numbers:");
            //for (int i = 0; i < 5; i++)
            //{
            //    number.Add(int.Parse(Console.ReadLine()));
            //}
            //Console.WriteLine("Number are:");
            //for(int i = 0;i < 5; i++)
            //{
            //    Console.WriteLine(number[i]);
            //    sum = sum + number[i];
            //}
            //Console.WriteLine("Sum is:" + sum);
            //Console.WriteLine( number.Count);
            //for (int i = 0; i <=4; i++)
            //{
            //    number.Add(int.Parse(Console.ReadLine()));

            //}
            //Console.WriteLine("Numbers are:");
            //for (int i = 0; i <=4; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}
            //int count=0;
            //Dictionary<int, string> student = new Dictionary<int, string>();
            //for(int i=0; i<5; i++)
            //{
            //    Console.WriteLine("Enter Data:");
            //    student.Add(i, Console.ReadLine());
            //    //count++;
            //}
            //for(int i=0; i < 5; i++)
            //{
            //    Console.WriteLine(i+ ":" + student[i]);
            //}
            //    Console.WriteLine("Total Students are:" +student.Count);
            //Dictionary<string,int>students= new Dictionary<string,int>();
            //int total = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Enter student name:");
            //    string name=Console.ReadLine();
            //    Console.WriteLine("Enter Students marks:");
            //    int marks=int.Parse(Console.ReadLine());
            //    students.Add(name, marks);
            //}
            //    Console.WriteLine("Students Record:");
            //for (int i = 0;i < 5; i++)
            //{
            //    Console.WriteLine(students.ElementAt(i).Key+ ":" + students.ElementAt(i).Value);
            //    total+=students.ElementAt(i).Value;
            //}
            //Console.WriteLine("Total:" + total);
            int maxprice = 0;
            string maxproduct = "";
            Dictionary<string, int> product = new Dictionary<string, int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Product name:");
                string product_name = Console.ReadLine();
                Console.WriteLine("Enter product price:");
                int product_price=int.Parse(Console.ReadLine());
                product.Add(product_name, product_price);
            }
            for(int i = 0;i < 5; i++)
            {
                Console.WriteLine(product.ElementAt(i).Key + ":" + product.ElementAt(i).Value);
                //string produc_name = product.ElementAt(i).Key;
                //int product_price = product.ElementAt(i).Value;
                if (product.ElementAt(i).Value > maxprice)
                {
                    maxprice = product.ElementAt(i).Value;
                    maxproduct = product.ElementAt(i).Key;
                }
            }
            Console.WriteLine("Produt name according to max price:"+maxproduct);
            Console.WriteLine("Max price of Product:"+maxprice);
        }
    }
}
