using System;
using System.Collections.Generic;
using System.Linq;
using TheModel;

namespace FindingAny
{
    public class Program
    {
        private static void FindingAny()
        {
            List<Order> orders = Order.GetSampleGenericList();

            bool anyRefunded = false;
            foreach (Order order in orders)
            {
                if (order.Status == OrderStatus.Refunded)
                {
                    anyRefunded = true;
                    break;
                }
            }

            if (anyRefunded)
                Console.WriteLine("Existen devoluciones");
            else
                Console.WriteLine("Sin devoluciones");
        }

        private static void FindingAnyUsingLinqExtensionMethod()
        {
            var orders = Order.GetSampleGenericList();
            var anyRefunded = orders.Any(o => o.Status == OrderStatus.Refunded);

            if (anyRefunded)
                Console.WriteLine("Existen devoluciones");
            else
                Console.WriteLine("Sin devoluciones");
        }

        public static void Main(string[] args)
        {
            FindingAny();
            FindingAnyUsingLinqExtensionMethod();
            Console.ReadKey();
        }
    }
}