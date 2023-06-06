public class Product
{
    public string Name {get; private set;}
    public int Count {get; private set;}
    public int Sold {get; private set;}
    public double Prize {get; private set;}

    public Product(string name, int initialCount, double prize)
    {
        this.Name = name;
        this.Count = initialCount;
        this.Prize = prize;
    }

    public void Despatch()
    {
        this.Sold += 1;
    }

    public double TotalPrize { get { return this.Sold * this.Prize; } }
}