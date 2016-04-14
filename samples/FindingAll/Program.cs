using System;
using System.Collections.Generic;
using System.Linq;
using TheModel;

namespace FindingAll
{
    public class Program
    {
        private static void FindingAll()
        {
            List<Order> orders = Order.GetSampleGenericList();

            bool allDelivered = orders.All(order => order.Status == OrderStatus.Delivered);

            if (allDelivered)
                Console.WriteLine("Todas las ordenes fueron entregadas");
            else
                Console.WriteLine("No todo ha sido entregado");
        }

        private static void FindingAllUsingLinqExtensionMethod()
        {
            var orders = Order.GetSampleGenericList();

            var allDelivered = orders.All(o => o.Status == OrderStatus.Delivered);

            if (allDelivered)
                Console.WriteLine("Todas las ordenes fueron entregadas");
            else
                Console.WriteLine("No todo ha sido entregado");
        }

        public static void Main(string[] args)
        {
            FindingAll();
            FindingAllUsingLinqExtensionMethod();
            Console.ReadKey();
        }
    }
}
