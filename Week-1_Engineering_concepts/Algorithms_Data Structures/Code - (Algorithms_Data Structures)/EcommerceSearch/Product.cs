namespace EcommerceSearch
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public Product(string id, string name, string category)
        {
            ProductId = id;
            ProductName = name;
            Category = category;
        }

        public override string ToString()
        {
            return $"{ProductId} | {ProductName} | {Category}";
        }
    }
}
