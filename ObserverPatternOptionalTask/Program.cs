using System;

class Program
{
    static void Main(string[] args)
    {
        StockMarket stock = new StockMarket("AAPL");

        Investor alice = new Investor("Alice");
        Investor bob = new Investor("Bob");
        Investor carol = new Investor("Carol");

        stock.Subscribe(alice);
        stock.Subscribe(bob);
        stock.Subscribe(carol);

        stock.Price = 150.00;

        stock.Unsubscribe(bob);
        Console.WriteLine("\n=== Bob unsubscribed ===");

        stock.Price = 165.50;

        Console.ReadKey();
    }
}