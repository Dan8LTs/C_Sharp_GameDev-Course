namespace _12
{
    internal class Cart
    {
        private List<Product> _products = new List<Product>();
        public Cart() 
        {
            _products.Add(new Product("Eggs"));
            _products.Add(new Product("Tomatoes"));
            _products.Add(new Product("Cheese"));
            _products.Add(new Product("Honey"));
        }

        public void ShowProducts()
        {
            foreach (Product product in _products) 
            {
                Console.WriteLine(product.Name);
            }
        }

        public int GetProductsCount()
        {
            return _products.Count;
        }

        public Product GetProductByIndex(int index)
        {
            return _products.ElementAt(index);
        }
    }
}
