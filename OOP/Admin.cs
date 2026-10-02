using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class Admin
    {
        int id;
        string name;
        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    Console.WriteLine("Id must be positive");
                }
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        internal void Showadmin()
        {
            Console.WriteLine("Id is:" + Id);
            Console.WriteLine("Name is:" + Name);
        }
    }
    internal class Manager : Admin
    {
        int salary;
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Salary is:" + Salary);
                }
            }
        }
        internal void Showmanager()
        {
            Console.WriteLine("Salary is:" + Salary);
        }
    }
    internal class employee:Manager
    {
        internal void Addincentive()
        {
            if(Salary < 50000)
            {
                Salary = Salary + (Salary * 15 / 100);
            }
            else
            {
                Salary = Salary + (Salary * 10 / 100);
            }
            Console.WriteLine("After Adding Incentive salary is:" + Salary);
        }
    }
}
