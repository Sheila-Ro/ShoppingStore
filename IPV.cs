public class IPV
{
    private Product[] ipv;

    public IPV(Product[] products)
    {
        this.ipv = new Product[products.Length];

        for (int i = 0; i < this.ipv.Length; i++)
            this.ipv[i] = products[i];
    }

    public void Print()
    {
        for (int i = 0; i < ipv.Length; i++)
        {
            Product p = ipv[i];

            System.Console.WriteLine("| {0} | {1} | {2} | {3} | {4} |", 
                                    p.Name, p.InitialCount, p.Count, p.Sold, p.Price, p.TotalSold);
        }
    }
}