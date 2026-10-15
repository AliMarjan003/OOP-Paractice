using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class Student
    {
        string name;
        int age, marks;
        public string Name
        {
            get { return name; }
            set
            { 
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can't be empty");
                } 
                else
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get { return  age; }
            set
            {
                if(value > 5||value<60)
                {
                    age=value;
                }
                else
                {
                    throw new ArgumentException("Age can't be less than 5 and can't be greater than 60");
                }
            }
        }
        public int Marks
        {
            get { return marks; }
            set
            {
                if(value > 0 || value < 100)
                {
                    marks=value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        internal void Show()
        {
            Console.WriteLine("Name of Student is:" + Name);
            Console.WriteLine("Age of Student is:" + Age);
            Console.WriteLine("Marks of Student are:" + Marks);
        }
    }
}
