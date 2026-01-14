using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Truck : Vehicle
    {
        public double LoadCapacity;
        public int NumberOfAxles;
        public Truck(string brand, string model, int year, double price, double loadCapacity, int numberOfAxles)
            :base(brand, model, year, price)
        {
            LoadCapacity = loadCapacity;
            NumberOfAxles = numberOfAxles;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Вантажівка: {Brand} {Model} {Year}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine($"Вантажопідйомність: {LoadCapacity} тонн");
            Console.WriteLine($"Кількість осей: {NumberOfAxles}");
            Console.WriteLine($"Максимальна швидкість: {GetMaxSpeed()} км/год");
            Console.WriteLine($"Транспортний податок: {CalculateTax()} грн");
        }
        public override double CalculateTax()
        {
            return Price * 0.02 + LoadCapacity * 1000;
        }
        public override int GetMaxSpeed()
        {
            return 120;
        }
    }
}
