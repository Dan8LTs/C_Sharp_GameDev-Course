using _12;

Cart cart = new Cart();
cart.ShowProducts();

List<Product> products = new List<Product>();

for (int i = 0; i < cart.GetProductsCount(); i++)
{
    products.Add(cart.GetProductByIndex(i));
}

products.RemoveAt(0);

Console.WriteLine();
cart.ShowProducts();