using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class Vehicle2
    {
        //string brand;
        internal virtual void showinfo()
        {
            Console.WriteLine("This is a vehicle");
        }
        internal void Honk()
        {
            Console.WriteLine("Generic honk sound");
        }
    }
    class Bike : Vehicle2
    {
        internal override void showinfo()
        {
            Console.WriteLine("This is a bike");
        }
        internal new void Honk()
        {
            Console.WriteLine("Bike horn sound");
        }
    }
}
