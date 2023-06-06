internal class Program
{
    private static IPV Ipv = new IPV(new Product[]
    {
        new Product("", 100, 10.00),
        new Product("", 100, 10.00),
        new Product("", 100, 10.00),
        new Product("", 100, 10.00),
        new Product("", 100, 10.00),
        new Product("", 100, 10.00),
        new Product("", 100, 10.00),
        new Product("", 100, 10.00),
        new Product("", 100, 10.00),
        new Product("", 100, 10.00),
    });
    private static Product[] Catalog = new Product[]
    {
        new Product("donas", 40, 80.00),
        new Product("señoritas", 30, 100),
        new Product("", 1, 1.00)
    };

    private static void Main(string[] args)
    {
        Cart cart = new Cart();

        while (true)
        {
            System.Console.Clear();

        }
    }    
}