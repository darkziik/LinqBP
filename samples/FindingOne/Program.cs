using System;
using System.Collections.Generic;
using System.Linq;
using TheModel;

namespace FindingOne
{
    public class Program
    {
        private static void FindingOne(int id)
        {
            List<Product> products = Product.GetSampleGenericList();

            Product productFound = null;
            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    productFound = product;
                    break;
                }
            }

            Console.WriteLine(productFound);
        }

        private static void FindingOneUsingLinqQueryExtensionSyntax(int id)
        {
            var products = Product.GetSampleGenericList();

            var query = from p in products
                        where p.Id == id
                        select p;

            var productFound = query.First();

            Console.WriteLine(productFound);
        }

        private static void FindingOneUsingLinqExtensionMethod(int id)
        {
            var products = Product.GetSampleGenericList();
            var productFound = products.First(p => p.Id == id);

            Console.WriteLine(productFound);
        }

        public static void Main(string[] args)
        {
            FindingOne(1);
            FindingOneUsingLinqQueryExtensionSyntax(1);
            FindingOneUsingLinqExtensionMethod(1);
            Console.ReadKey();
        }
    }
}