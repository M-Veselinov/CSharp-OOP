using System;
public class Laptop
{
    public string model;// = "MacBook Air";
    public string manufacturer;// = "Apple";
    public string processor;// = "Intel Core i7";
    public string graphicsCard;// = "Intel HD Graphics 5000";
    public string battery;//= "45W MagSafe 2";
    public int batteryLife = 0;// = 12;

    public Laptop(string graphics,string laptopProcessor,string laptopManufacturer,string laptopModel,string batteryModel, int batteryLength)
    {
        if (String.IsNullOrEmpty(graphics) || String.IsNullOrEmpty(laptopProcessor) || String.IsNullOrEmpty(laptopManufacturer) || String.IsNullOrEmpty(laptopModel) || String.IsNullOrEmpty(batteryModel))
        {
            throw new ArgumentException("Arguments cannot be empty");
        }
        if (batteryLength < 0)
        {
            throw new ArgumentException("Numeric data cannot be negative");
        }
        batteryLife = batteryLength;
        model = laptopModel;
        manufacturer = laptopManufacturer;
        processor = laptopProcessor;
        graphicsCard = graphics;
        battery = batteryModel;
    }
    public Laptop(string graphics, string laptopProcessor, string laptopManufacturer, string laptopModel, string batteryModel)
    {
        model = laptopModel;
        manufacturer = laptopManufacturer;
        processor = laptopProcessor;
        graphicsCard = graphics;
        battery = batteryModel;
        if (String.IsNullOrEmpty(graphics) || String.IsNullOrEmpty(laptopProcessor) || String.IsNullOrEmpty(laptopManufacturer) || String.IsNullOrEmpty(laptopModel) || String.IsNullOrEmpty(batteryModel))
        {
            throw new ArgumentException("Arguments cannot be empty");
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine(model);
        Console.WriteLine(manufacturer);
    }
}
    class Program
    {
        static void Main()
        {
            Laptop newLaptop = new Laptop("Intel HD Graphics 5000","Intel Core i7","Apple","MacBook Air","45W MagSafe 2");
            Console.WriteLine(newLaptop.battery);
            newLaptop.DisplayInfo();
        }
    }
