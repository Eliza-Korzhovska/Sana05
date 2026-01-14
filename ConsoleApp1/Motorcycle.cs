using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Motorcycle : Vehicle
    {
        public int EngineVolume;
        public bool HasWindshield;
        public Motorcycle(string brand, string model, int year, double price, int engineVolume, bool hasWindshield)
            : base(brand, model, year, price)
        {
            EngineVolume = engineVolume;
            HasWindshield = hasWindshield;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Мотоцикл: {Brand} {Model} {Year}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine($"Об'єм двигуна: {EngineVolume} см³");
            Console.WriteLine($"Вітрове скло: {(HasWindshield ? "Так" : "Ні")}");
            Console.WriteLine($"Максимальна швидкість: {GetMaxSpeed()} км/год");
            Console.WriteLine($"Транспортний податок: {CalculateTax()} грн");
        }
        public override double CalculateTax()
        {
            return Price * 0.008 + EngineVolume * 0.5;
        }
        public override int GetMaxSpeed()
        {
            return 200;
        }
    }
}
