public class Cart
{
    public Dictionary<Product, int> ProductsInCart;

    public Cart()
    {
        this.ProductsInCart = new Dictionary<Product, int>();
    }

    public void AddToCart(Product product, int units)
    {
        this.ProductsInCart.Add(product, units);
    }

    public double TotalCost()
    {
        double totalCost = 0;

        foreach (Product product in this.ProductsInCart.Keys)
        {
            totalCost = product.Sell(ProductsInCart[product]);
        }

        return totalCost;
    }
}