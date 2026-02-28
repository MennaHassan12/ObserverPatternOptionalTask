using ObserverPatternOptional;
using System;
using System.Runtime.InteropServices.JavaScript;

public delegate void StockUpdateHandler(string stockName, double newPrice);

public class StockMarket : ISubject
{
    public string StockName
    {
        get;
        private set;
    }

    private double _price;

    public double Price
    {
        get => _price;
        set
        {
            _price = value;
            Notify();
        }
    }

    private event StockUpdateHandler StockUpdated;

    public StockMarket(string stockName)
    {
        StockName = stockName;
    }

    public void Subscribe(IObserver observer)
    {
        StockUpdated += observer.Update;
    }

    public void Unsubscribe(IObserver observer)
    {
        StockUpdated -= observer.Update;
    }

    public void Notify()
    {
        Console.WriteLine($"\n=== Stock Price Update: {StockName} = ${Price} ===");
        StockUpdated?.Invoke(StockName, Price);
    }
}