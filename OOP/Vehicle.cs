using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    //Interface
    //En klass kan implementera (ärva) från många interface
    //Allt är publikt 
    //(Med C# 8 kan vi har privata statiska medlemmar, samt publika/privata metoder med default implemenation)
    //Måste Implementeras i ärvda klasser
    //(Kan ha implementation from c# 8)
    //Kan inte implementeras - ej skapa objekt av med new
    internal interface IDrivable
    {
        string Drive(int distance);
    }

    internal interface IStoppable
    {
         string Stop();
    }

    //Abstrakt
    //Kan inte implementeras - ej skapa objekt av med new
    //Kan inehålla en blandnig av vanliga metoder och abstrakta metoder utan implementation
    //Alla abstrakta medlemmar måste implemneteras av dem som ärver från den abstrakta klassen
    //Kan hålla privata fält
    //AbstractVehicle implementerar IDrivable
    internal abstract class AbstractVehicle : IDrivable
    {
        //Virtual - En metod som markeras med nykelordet virtual är ok att skriva en ny implementation i  ärvda klasser
        public virtual string Drive(int distance)
        {
            return $"{this.GetType().Name} drove for {distance}";
        }

        //Håller ingen implementation måste implementeras i ärvda klasser
        //Nykelordet abstract kan bara användas i abstrakta klasser och interfaces
        public abstract string Turn();

    }

    //Vehicle ärver från AbstractVehicle, Vehicle är en AbstractVehicle
    internal class Vehicle : AbstractVehicle
    {
        public string Brand { get; set; }
        public string RegNo { get; }

        public Vehicle(string brand, string regNo)
        {
            Brand = brand;
            RegNo = regNo;
        }

        //Overide egen implementation av Turn, mer specialiserad variant
        public override string Turn()
        {
            return "Vehicle turns";
        }
    }

    internal class Car : Vehicle
    {
        public string Model { get; set; }

        //Nyckelordet base menar i det här fallet att vi anropar basklassens konstruktor
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
        //Overide egen implementation av Turn, mer specialiserad variant
        public override string Turn()
        {
            return "Bicycle turns";
        }

        //Eftersom vi inte använder oss av några instans medlemmar får vi förslaget att göra metoden static
        public string MethodInOnlyBicyle()
        {
            return "From Bicycle";
        }
    }
}
