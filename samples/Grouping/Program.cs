using System;
using System.Collections.Generic;
using System.Linq;
using TheModel;

namespace Grouping
{
    public class Program
    {
        public static void Grouping()
        {
            List<Order> orders = Order.GetSampleGenericList();

            Dictionary<string, List<Order>> ordersByCustomer = new Dictionary<string, List<Order>>();
            foreach(Order order in orders)
            {
                if (!ordersByCustomer.ContainsKey(order.CustomerName))
                    ordersByCustomer[order.CustomerName] = new List<Order>();
                ordersByCustomer[order.CustomerName].Add(order);
            }

            foreach (string customer in ordersByCustomer.Keys)
                foreach (Order order in ordersByCustomer[customer])
                    Console.WriteLine(order);
        }

        public static void GroupingUsingLinqExtensionMethod()
        {
            var orders = Order.GetSampleGenericList();

            var ordersByCustomer = orders.GroupBy(o => o.CustomerName)
                                         .ToDictionary(g => g.Key, g => g.ToList());

            foreach (var customer in ordersByCustomer.Keys)
                foreach (var order in ordersByCustomer[customer])
                    Console.WriteLine(order);
        }

        public static void Main(string[] args)
        {
            Grouping();
            GroupingUsingLinqExtensionMethod();
            Console.ReadKey();
        }
    }
}