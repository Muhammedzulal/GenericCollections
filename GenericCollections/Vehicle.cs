using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public abstract class Vehicle
    {
        public abstract override string ToString();
    }
    //*****Car-Truck-Motorcycle-Bus-Bicycle*****
    public class Car : Vehicle
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Year} {Model}";
        }
    }

    public class Truck : Vehicle
    {
        public string Model { get; set; }
        public int LoadCapacity { get; set; }
        public Truck(string model, int loadCapacity)
        {
            Model = model;
            LoadCapacity = loadCapacity;
        }
        public override string ToString()
        {
            return $"{Model} with load capacity of {LoadCapacity} tons";
        }
    }

    public class Motorcycle : Vehicle
    {
        public string Model { get; set; }
        public int EngineSize { get; set; }
        public Motorcycle(string model, int engineSize)
        {
            Model = model;
            EngineSize = engineSize;
        }
        public override string ToString()
        {
            return $"{Model} with engine size of {EngineSize}cc";
        }
    }

    public class Bus : Vehicle
    {
        public string Model { get; set; }
        public int PassengerCapacity { get; set; }
        public Bus(string model, int passengerCapacity)
        {
            Model = model;
            PassengerCapacity = passengerCapacity;
        }
        public override string ToString()
        {
            return $"{Model} with capacity of {PassengerCapacity} passengers";
        }
    }
    public class Bicycle : Vehicle
    {
        public string Model { get; set; }
        public int GearCount { get; set; }
        public Bicycle(string model, int gearCount)
        {
            Model = model;
            GearCount = gearCount;
        }
        public override string ToString()
        {
            return $"{Model} with {GearCount} gears";
        }
    }
}
