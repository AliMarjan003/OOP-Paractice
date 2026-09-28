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
            Console.WriteLine("Name of Person is:" + name);
            Console.WriteLine("Age of perosn is:" + age);
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
        internal void showStudent()
        {
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
                if(value > 0)
                {
                    Marks = value;
                }
                else
                {
                    Console.WriteLine("Enter Positive marks");
                }
            }
        }
        internal void showStudent()
        {
            Console.WriteLine("Marks are:" + Marks);
        }
    }
}
