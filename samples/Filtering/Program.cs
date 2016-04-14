using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TheModel;

namespace Filtering
{
    public class Program
    {
        #region C# 1.0

        private static void Filtering()
        {
            ArrayList products = Product.GetSampleArrayList();

            foreach (Product product in products)
                if (product.Price > 50.00m)
                    Console.WriteLine(product);
        }

        #endregion

        #region C# 2.0

        private static void FilteringUsingDelegate()
        {
            List<Product> products = Product.GetSampleGenericList();

            products.FindAll(delegate (Product p) { return p.Price > 50.00m; })
                    .ForEach(Console.WriteLine);
        }

        #endregion

        #region C# 3.0

        private static void FilteringUsingLambdaExpression()
        {
            var products = Product.GetSampleGenericList();

            products.FindAll(p => p.Price > 50.00m)
                    .ForEach(Console.WriteLine);
        }

        private static void FilteringUsingLinqQueryExtensionSyntax()
        {
            var products = Product.GetSampleGenericList();

            var filtered = from p in products
                           where p.Price > 50.00m
                           select p;

            foreach (var product in filtered)
                Console.WriteLine(product);
        }

        private static void FilteringUsingLinqExtensionMethod()
        {
            var products = Product.GetSampleGenericList();

            foreach (var product in products.Where(p => p.Price > 50.00m))
                Console.WriteLine(product);
        }

        #endregion

        public static void Main(string[] args)
        {
            Filtering();
            FilteringUsingDelegate();
            FilteringUsingLambdaExpression();
            FilteringUsingLinqQueryExtensionSyntax();
            FilteringUsingLinqExtensionMethod();
            Console.ReadKey();
        }
    }
}