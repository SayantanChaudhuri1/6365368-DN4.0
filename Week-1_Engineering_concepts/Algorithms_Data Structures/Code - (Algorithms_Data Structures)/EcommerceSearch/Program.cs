using System;

namespace EcommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product("P001", "Laptop", "Electronics"),
                new Product("P002", "Shirt", "Clothing"),
                new Product("P003", "Phone", "Electronics"),
                new Product("P004", "Shoes", "Footwear")
            };

            Console.WriteLine("🔍 Linear Search for 'Phone':");
            var linearResult = SearchAlgorithms.LinearSearch(products, "Phone");
            Console.WriteLine(linearResult != null ? linearResult.ToString() : "Product not found");

            // Sort the products by ProductName for binary search
            Array.Sort(products, (p1, p2) => p1.ProductName.CompareTo(p2.ProductName));

            Console.WriteLine("\n🔍 Binary Search for 'Phone':");
            var binaryResult = SearchAlgorithms.BinarySearch(products, "Phone");
            Console.WriteLine(binaryResult != null ? binaryResult.ToString() : "Product not found");

            Console.ReadLine();
        }
    }
}
