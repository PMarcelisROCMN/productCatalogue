namespace ProductCatalogue
{
    public class Product
    {

        public Product(string name, decimal price, string shortDesc)
        {
            Name = name;
            Price = price;
            ShortDescription = shortDesc;
        }

        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string ShortDescription { get; private set; }
    }
}
