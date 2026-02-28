using ObserverPatternOptional;
using System;

public class Investor : IObserver
{
    public string Name { get; set; }

    public Investor(string name)
    {
        Name = name;
    }

    public void Update(string stockName, double price)
    {
        Console.WriteLine($"[{Name}] {stockName} stock is now ${price}");
    }
}