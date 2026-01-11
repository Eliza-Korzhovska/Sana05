using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vehicle
    {
        public string Brand;
        public string Model;
        public int Year;
        public double Price;
        public Vehicle(string brand, string model, int year, double price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        } 
        public string GetBrand() { return Brand; }
        public string GetModel() { return Model; }
        public int GetYear() { return Year; }
        public double GetPrice() { return Price; }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Brand} {Model} {Year}");
            Console.WriteLine($"Ціна: {Price} грн");
        }
        public virtual double CalculateTax()
        {
            return Price * 0.01;
        }
        public virtual int GetMaxSpeed()
        {
            return 100;
        }
    }
}
