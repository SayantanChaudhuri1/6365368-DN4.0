namespace OrderSorting
{
    public class Order
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public double TotalPrice { get; set; }

        public Order(string id, string name, double price)
        {
            OrderId = id;
            CustomerName = name;
            TotalPrice = price;
        }

        public override string ToString()
        {
            return $"{OrderId} | {CustomerName} | Rs. {TotalPrice}";
        }
    }
}
