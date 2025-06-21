using System;

namespace EcommerceSearch
{
    public class SearchAlgorithms
    {
        public static Product LinearSearch(Product[] products, string targetName)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(targetName, StringComparison.OrdinalIgnoreCase))
                    return product;
            }
            return null;
        }

        public static Product BinarySearch(Product[] products, string targetName)
        {
            int low = 0, high = products.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int comparison = string.Compare(products[mid].ProductName, targetName, true);

                if (comparison == 0) return products[mid];
                else if (comparison < 0) low = mid + 1;
                else high = mid - 1;
            }
            return null;
        }
    }
}
