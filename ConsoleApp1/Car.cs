using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car : Vehicle
    {
        public int NumberOfDoors;
        public string FuelType;
        public Car(string brand, string model, int year, double price, int numberOfDoors, string fuelType)
            :base(brand, model, year, price)
        {
            NumberOfDoors = numberOfDoors;
            FuelType = fuelType;
        }
        public int GetNumberOfDoors() { return NumberOfDoors; }
        public string GetFuelType() { return FuelType; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Легковий автомобіль: {Brand} {Model} {Year}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine($"Кількість дверей: {NumberOfDoors}");
            Console.WriteLine($"Тип палива: {FuelType}");
            Console.WriteLine($"Максимальна швидкість: {GetMaxSpeed()} км/год");
            Console.WriteLine($"Транспортний податок: {CalculateTax()} грн");
        }
        public override double CalculateTax()
        {
            if (FuelType.ToLower() == "електро") 
                return Price * 0.005;
            else 
                return Price * 0.015;
        }
        public override int GetMaxSpeed()
        {
            return 180;
        }
    }
}
