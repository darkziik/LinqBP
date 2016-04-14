using System.Collections.Generic;

namespace TheModel
{
    public class Order
    {
        public int Id { get; private set; }
        public decimal Amount { get; private set; }
        public string CustomerName { get; private set; }
        public OrderStatus Status { get; private set; }

        public Order(int id, decimal amount, string customerName, OrderStatus status)
        {
            Id = id;
            Amount = amount;
            CustomerName = customerName;
            Status = status;
        }

        public override string ToString() => $"{CustomerName}: Id: {Id} Amount: {Amount} Status: {Status}";

        public static List<Order> GetSampleGenericList()
        {
            return new List<Order>
            {
                new Order(1, 29.17m, "Yoko", OrderStatus.Delivered),
                new Order(2, 65.23m, "Davis", OrderStatus.InProgress),
                new Order(3, 54.22m, "Inez", OrderStatus.Refunded),
                new Order(4, 70.82m, "Jin", OrderStatus.Shipped),
                new Order(5, 76.14m, "Colt", OrderStatus.Delivered),
                new Order(6, 76.91m, "Davis", OrderStatus.Delivered),
                new Order(7, 45.00m, "Emmanuel", OrderStatus.Created),
                new Order(8, 73.00m, "Davis", OrderStatus.Refunded),
                new Order(9, 55.20m, "Dean", OrderStatus.Delivered),
                new Order(10, 16.40m, "Kiayada", OrderStatus.Delivered),
            };
        }
    }
}