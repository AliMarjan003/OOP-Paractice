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
            get {  return brand; }
            set { brand = value; }
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                if(value>0)
                {
                    speed=value;
                }
                else
                {
                    Console.WriteLine("Speed must be positive");
                }
            }
        }
        internal void Showvehicle()
        {
            Console.WriteLine("Brand:" + Brand);
            Console.WriteLine("Speed:" + Speed);
        }
    }
    internal class car:Vehicle
    {
        int doors;
        public int Doors
        {
            get { return doors; }
            set
            {
                if(value > 0)
                {
                    doors=value;
                }
                else
                {
                    Console.WriteLine("put at least 1 door");
                }
            }
        }
        internal void ShowCar()
        {
            Console.WriteLine("Doors are:"+Doors);
        }
    }
    internal class Sportscar : car
    {
        int topspeed;
        public int Topspeed
        {
            get{ return topspeed; }
            set
            {
                if(value>=Speed)
                {
                    topspeed = value;
                }
                else
                {
                    Console.WriteLine("Top speed cannot be less than normal speed");
                }
            }
        }
        internal void Showsportscar()
        {
            Console.WriteLine("Top speed:"+topspeed);
        }
    }
}
