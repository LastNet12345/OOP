using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal interface IDrivable
    {
        string Drive(int distance);
    } 
    
    internal interface IStoppable
    {
        string Stop();
    }

    internal class Vehicle : IDrivable
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public virtual string Drive(int distance)
        {
            return $"{this.GetType().Name} drove for {distance}";
        }
    }

    internal class Car : Vehicle
    {
        public string Model { get; set; }
        public Car(string brand, string model) : base(brand)
        {
            Model = model;
        }

        public override string Drive(int distance)
        {
            return $"{base.Drive(distance)} From: {GetType().Name}";
        }
    }


    internal class Ferrari : Car, IStoppable
    {
        public Ferrari(string model = "Testarosa") : base("Ferrari", model){}

        public string Stop()
        {
            return "Stop";
        }


    }
}
