internal class Program
{
    private static void Main(string[] args)
    {
        Product[] products = new Product[]
        {
            new Product("donas", 40, 80.00),
            new Product("señoritas", 30, 100),
            new Product("", 1, 1.00)
        };



        Print(products);
    }

    public static void Sell()
    {
        
    }

    public static void Print(Product[] products)
    {
        for (int i = 0; i < products.Length; i++)
        {
            Product p = products[i];
            System.Console.WriteLine("| {0} | {1} | {2} | {3} |", p.Name, p.Count, p.Sold, p.Prize, p.TotalPrize);
        }
    }
}