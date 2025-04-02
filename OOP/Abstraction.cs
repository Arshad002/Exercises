using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Vehicle
    {
        public string Brand
        {
            get; protected set;
        }

        public Vehicle(string brand)
        {
            Brand = brand;
        }
        public abstract void StartEngine();
        public abstract void StopEngine();

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand : {this.Brand}");
        }

    }

    public class Car : Vehicle
    {
        public Car(string brand) : base(brand) 
        { 
        }
        public override void StartEngine()
        {
            Console.WriteLine("Car Engine Started");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car Engine Stopped");
        }
    }

    public class Bike : Vehicle
    {
        public Bike(string brand) : base(brand) 
        { 
        }
        public override void StartEngine()
        {
            Console.WriteLine("Bike Engine Started");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Bike Engine Stopped");
        }
    }
}
