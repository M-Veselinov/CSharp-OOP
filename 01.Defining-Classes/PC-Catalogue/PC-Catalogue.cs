using System;


class Computer
{
    public string computerName;
    private string processor;
    private string graphicsCard;
    private string motherBoard;
    public double computerPrice;

    public  Computer(string name)
    {
        computerName = name;
    }
    Component component1 = new Component("processor",26);
    Component component2 = new Component("graphics card",120.36);
    Component component3 = new Component("motherboard",130.57);

    public void DisplayInfo() 
    {
        Console.WriteLine(computerName);
        Console.WriteLine(component1.Name);
        Console.WriteLine(component2.Name);
        Console.WriteLine(component3.Name);
        computerPrice = component1.Price + component2.Price + component3.Price;
        Console.WriteLine(computerPrice + " BGN");
    }

    public void SortComputers()
    { 
        
    }
}

class Program
{
    static void Main()
    {
        Computer comp = new Computer("Sony");
        comp.DisplayInfo();
    }
}
