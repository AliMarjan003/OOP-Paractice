using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OOP
{
    internal class Person
    {
        int age;
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age must be positive");
                }
            }
        }
        internal void Showperson()
        {
            Console.WriteLine("Name of Perosn is:" + Name);
            Console.WriteLine("Age of Person is:" + Age);
        }
    }
    internal class Teacher:Person
    {
        int Salary;
        public int salary
        {
            get { return Salary; }
            set
            {
                if (value > 0)
                {
                    Salary = value;
                }
                else
                {
                    Console.WriteLine("Salary Positive ");
                }
            }
        }
        internal void Showteacher()
        {
            //Console.WriteLine("Name of Teacher is:" + Name);
            //Console.WriteLine("Age of Teacher is:" + Age);
            Console.WriteLine("Salary is:" + Salary);
        }
    }
    internal class inheritstudent:Person
    {
        int Marks;
        public int marks
        {
            get { return Marks; }
            set
            {
                if(value >= 0 && value<=100)
                {
                    Marks = value;
                }
                else
                {
                    Console.WriteLine("Enter Positive marks");
                }
            }
        }
        internal void Showstudent()
        {
            //Console.WriteLine("Name of Student is:" + Name);
            //Console.WriteLine("Age of perosn is:" + Age);
            Console.WriteLine("Marks are:" + Marks);
        }
    }
}
