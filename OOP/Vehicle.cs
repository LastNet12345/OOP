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

    internal class Vehicle : IDrivable
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public virtual string Drive(int distance)
        {
            return $"Vehicle drove for {distance}";
        }
    }

    internal class Car : Vehicle
    {
        public string Model { get; set; }
        public Car(string brand, string model) : base(brand)
        {
            Model = model;
        }

    }
}
