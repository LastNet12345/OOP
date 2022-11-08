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

    internal abstract class AbstractVehicle : IDrivable
    {
        public virtual string Drive(int distance)
        {
            return $"{this.GetType().Name} drove for {distance}";
        }

        public abstract string Turn();

    }

    internal class Vehicle : AbstractVehicle
    {
        public string Brand { get; set; }
        public string RegNo { get; }

        public Vehicle(string brand, string regNo)
        {
            Brand = brand;
            RegNo = regNo;
        }

        public override string Turn()
        {
            return "Vehicle turns";
        }
    }

    internal class Car : Vehicle
    {
        public string Model { get; set; }
        public Car(string brand, string model, string regNo) : base(brand, regNo)
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
        public Ferrari(string model = "Testarosa") : base("Ferrari", model, "ABC123"){}

        public string Stop()
        {
            return "Stop";
        }


    }

    internal class Bicycle : AbstractVehicle
    {
        public override string Turn()
        {
            return "Bicycle turns";
        }

        public string MethodInOnlyBicyle()
        {
            return "From Bicycle";
        }
    }
}
