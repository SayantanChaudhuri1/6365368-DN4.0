using System;

namespace OrderSorting
{
    public class SortingAlgorithms
    {
        public static void BubbleSort(Order[] orders)
        {
            int n = orders.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                    {
                        // Swap
                        var temp = orders[j];
                        orders[j] = orders[j + 1];
                        orders[j + 1] = temp;
                    }
                }
            }
        }

        public static void QuickSort(Order[] orders, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(orders, low, high);

                QuickSort(orders, low, pi - 1);
                QuickSort(orders, pi + 1, high);
            }
        }

        private static int Partition(Order[] orders, int low, int high)
        {
            double pivot = orders[high].TotalPrice;
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (orders[j].TotalPrice < pivot)
                {
                    i++;
                    var temp = orders[i];
                    orders[i] = orders[j];
                    orders[j] = temp;
                }
            }

            var temp1 = orders[i + 1];
            orders[i + 1] = orders[high];
            orders[high] = temp1;

            return i + 1;
        }
    }
}
