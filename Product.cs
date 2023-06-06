public class Product
{
    public string Name {get; private set;}
    public int InitialCount {get; private set;}
    public int Count {get; private set;}
    public int Sold {get; private set;}
    public double Price {get; private set;}

    public Product(string name, int initialCount, double price)
    {
        this.Name = name;
        this.InitialCount = this.Count = initialCount;
        this.Price = price;
    }

    public double Sell(int units)
    {
        this.Sold += units;
        this.Count -= units;
        return this.Price * units;
    }

    public double TotalSold { get { return this.Sold * this.Price; } }
}