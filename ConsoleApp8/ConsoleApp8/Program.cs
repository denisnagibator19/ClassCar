using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Car(string name, string model, int year)
        {
            Name = name;
            Model = model;
            Year = year;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Car Name: {Name}, Model: {Model}, Year: {Year}");
        }
    }
    class PassengerCar : Car
    {
        public int NumberOfSeats { get; set; }
        public PassengerCar(string name, string model, int year, int numberOfSeats) : base(name, model, year)
        {
            NumberOfSeats = numberOfSeats;
        }
        public void DisplayPassengerCarInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Number of Seats: {NumberOfSeats}");
        }
    }
    class Truck : Car
    {
        public int LoadCapacity { get; set; }
        public Truck(string name, string model, int year, int loadCapacity) : base(name, model, year)
        {
            LoadCapacity = loadCapacity;
        }
        public void DisplayTruckInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Load Capacity: {LoadCapacity} kg");
        }
    }
    class SportCar : Car
    {
        public int TopSpeed { get; set; }
        public SportCar(string name, string model, int year, int topSpeed) : base(name, model, year)
        {
            TopSpeed = topSpeed;
        }
        public void DisplaySportCarInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Top Speed: {TopSpeed} km/h");
        }
    }
    class Bus : Car
    {
        public int PassengerCapacity { get; set; }
        public Bus(string name, string model, int year, int passengerCapacity) : base(name, model, year)
        {
            PassengerCapacity = passengerCapacity;
        }
        public void DisplayBusInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Passenger Capacity: {PassengerCapacity}");
        }
    }
    class electricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public electricCar(string name, string model, int year, int batteryCapacity) : base(name, model, year)
        {
            BatteryCapacity = batteryCapacity;
        }
        public void DisplayElectricCarInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Battery Capacity: {BatteryCapacity} kWh");
        }
    }
    class SUV : Car
    {
        public bool AllWheelDrive { get; set; }
        public SUV(string name, string model, int year, bool allWheelDrive) : base(name, model, year)
        {
            AllWheelDrive = allWheelDrive;
        }
        public void DisplaySUVInfo()
        {
            DisplayInfo();
            Console.WriteLine($"All-Wheel Drive: {AllWheelDrive}");
        }
    }
    class HybridCar : Car
    {
        public int FuelEfficiency { get; set; }
        public HybridCar(string name, string model, int year, int fuelEfficiency) : base(name, model, year)
        {
            FuelEfficiency = fuelEfficiency;
        }
        public void DisplayHybridCarInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Fuel Efficiency: {FuelEfficiency} km/l");
        }
    }
    class LuxuryCar : Car
    {
        public string InteriorMaterial { get; set; }
        public LuxuryCar(string name, string model, int year, string interiorMaterial) : base(name, model, year)
        {
            InteriorMaterial = interiorMaterial;
        }
        public void DisplayLuxuryCarInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Interior Material: {InteriorMaterial}");
        }
    }
    class motorcycle : Car
    {
        public int NumberOfCylinders { get; set; }
        public motorcycle(string name, string model, int year, int numberOfCylinders) : base(name, model, year)
        {
            NumberOfCylinders = numberOfCylinders;
        }
        public void DisplayMotorcycleInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Number of Cylinders: {NumberOfCylinders}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
