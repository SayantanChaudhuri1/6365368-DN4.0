using System;

namespace OrderSorting
{
    class Program
    {
        static void PrintOrders(Order[] orders)
        {
            foreach (var order in orders)
                Console.WriteLine(order);
        }

        static void Main(string[] args)
        {
            Order[] orders1 = new Order[]
            {
                new Order("O001", "Alice", 4000),
                new Order("O002", "Bob", 9000),
                new Order("O003", "Charlie", 3000),
                new Order("O004", "David", 7000)
            };

            // Clone for Quick Sort
            Order[] orders2 = (Order[])orders1.Clone();

            Console.WriteLine("🌀 Bubble Sort by Total Price:");
            SortingAlgorithms.BubbleSort(orders1);
            PrintOrders(orders1);

            Console.WriteLine("\n⚡ Quick Sort by Total Price:");
            SortingAlgorithms.QuickSort(orders2, 0, orders2.Length - 1);
            PrintOrders(orders2);

            Console.ReadLine();
        }
    }
}
