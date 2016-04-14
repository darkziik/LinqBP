using System;
using System.Linq;
using System.Collections.Generic;
using TheModel;

namespace Counting
{
    public class Program
    {
        private static void Counting()
        {
            List<Order> orders = Order.GetSampleGenericList();
            int refundedCount = 0;

            foreach (var order in orders)
                if (order.Status == OrderStatus.Refunded)
                    refundedCount++;

            Console.WriteLine(refundedCount);
        }

        private static void CountingUsingLinqExtensionMethod()
        {
            var orders = Order.GetSampleGenericList();
            var refundedCount = orders.Count(o => o.Status == OrderStatus.Refunded);

            Console.WriteLine(refundedCount);
        }

        public static void Main(string[] args)
        {
            Counting();
            CountingUsingLinqExtensionMethod();
            Console.ReadKey();
        }
    }
}