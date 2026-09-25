using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class Student
    {
        string name;
        int marks;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Marks{
            get { return marks; }
            set { if (value >= 0 && value <= 100)
                    marks = value;
                else
                    Console.WriteLine("Marks must b/w 0 and 100");
            }
        }
    }
    internal class Classroom
    {
        private Student[] students =new Student[3];
        public Student this[int index]
        {
            get {  return students[index]; }
            set { students[index] = value; }
        }
    }
}
