using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class emp
    {
        int empid, age;
        string empname;
        internal void Accept(int empid,string empname, int age)
        {
            this.empid = empid;
            this.empname = empname;
            this.age = age;
        }
        internal void Show()
        {
            Console.WriteLine("id:{0}, name:{1}, age:{2}",empid, empname,age);
        }
    }
}
