using ConsoleApp1;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

Vehicle[] vehicles = new Vehicle[4];
vehicles[0] = new Car("Infiniti", "Q50", 2023, 1200000, 4, "бензин");
vehicles[1] = new Truck("Volvo", "FH16", 2020, 3000000, 25, 4);
vehicles[2] = new Motorcycle("Yamaha", "R1", 2022, 800000, 1000, true);
vehicles[3] = new Car("Tesla", "Model 3", 2023, 1500000, 4, "електро");
Console.WriteLine("=== Інформація про транспортні засоби ===\n");
double totalTax = 0;
foreach (Vehicle vehicle in vehicles)
{
    vehicle.DisplayInfo();
    totalTax += vehicle.CalculateTax();
}
Vehicle fastest = vehicles[0];
foreach (Vehicle vehicle in vehicles)
{
    if (vehicle.GetMaxSpeed() > fastest.GetMaxSpeed())
        fastest = vehicle;
}
Console.WriteLine($"Загальна сума податків: {totalTax} грн");
Console.WriteLine($"Найшвидший транспорт: {fastest.Brand} {fastest.Model} ({fastest.GetMaxSpeed()} км/год)");
