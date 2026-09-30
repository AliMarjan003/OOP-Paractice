using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class Vehicle
    {
        string brand;
        int speed;
        public string Brand
        {
            get { return brand; }
            set
            {
                brand = value;
            }
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value>0)
                {
                    speed = value;
                }
                else
                {
                    Console.WriteLine("Speed must be positive");
                }
            }
        }
        internal void Showvehicle()
        {
            Console.WriteLine("Brand:"+Brand);
            Console.WriteLine("Speed:"+Speed);
        }
    }
    internal class Car : Vehicle
    {
        int doors;   //to count doors of car
        public int Doors
        {
            get { return  doors; }
            set
            {
                if(value>0)
                {
                    doors = value;
                }
                else
                {
                    Console.WriteLine("car must have atleast one door");
                }
            }
        }
        internal void Showcar()
        {
            Console.WriteLine("Doors:" + Doors);
        }
    }
    internal class Sportcar : Car
    {
        int topspeed;
        public int Topspeed
        {
            get { return topspeed; }
            set
            {
                if (value >= Speed)
                {
                    topspeed= value;
                }
                else
                {
                    Console.WriteLine("Top Speed can't be less than normal speed");
                }
            }
        }
        internal void Showsportcar()
        {
            Console.WriteLine("Top speed:"+Topspeed);
        }
    }
}
