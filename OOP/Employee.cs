using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class Employee
    {
        string name;
        int salary;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Salary
        {
            get { return salary;}
            set
            {
                if(value > 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Salary can't be negative"); 
                }
            }
        }
        internal void Applybonus()
        {
            salary = salary + (salary * 10 / 100);
        }
    }
    internal class Company
    {
        Employee[] emp = new Employee[4];
        public Employee this[ int index]
        {
            get { return emp[index]; }
            set { emp[index] = value; }
        }
    }
}
