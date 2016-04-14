using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TheModel;

namespace Sorting
{
    public class Program
    {
        #region C# 1.0

        private class ProductNameComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                Product first = (Product)x;
                Product second = (Product)y;
                return first.Name.CompareTo(second.Name);
            }
        }

        private static void SortingUsingComparer()
        {
            ArrayList products = Product.GetSampleArrayList();

            products.Sort(new ProductNameComparer());

            foreach (Product product in products)
                Console.WriteLine(product);
        }

        #endregion

        #region C# 2.0

        private class ProductNameGenericComparer : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        private static void SortingUsingGenericComparer()
        {
            List<Product> products = Product.GetSampleGenericList();

            products.Sort(new ProductNameGenericComparer());

            foreach (Product product in products)
                Console.WriteLine(product);
        }

        private static void SortingUsingDelegate()
        {
            List<Product> products = Product.GetSampleGenericList();

            products.Sort(delegate (Product x, Product y) { return x.Name.CompareTo(y.Name); });

            foreach (Product product in products)
                Console.WriteLine(product);
        }

        #endregion

        #region C# 3.0

        private static void SortingUsingLambdaExpression()
        {
            var products = Product.GetSampleGenericList();

            products.Sort((x, y) => x.Name.CompareTo(y.Name));

            foreach (var product in products)
                Console.WriteLine(product);
        }

        private static void SortingUsingLinqQueryExpressionSyntax()
        {
            var products = Product.GetSampleGenericList();

            var sorted = from p in products
                         orderby p.Name
                         select p;

            foreach (var product in sorted)
                Console.WriteLine(product);
        }

        private static void SortingUsingLinqExtensionMethod()
        {
            var products = Product.GetSampleGenericList();

            foreach (var product in products.OrderBy(p => p.Name))
                Console.WriteLine(product);
        }

        #endregion

        public static void Main(string[] args)
        {
            SortingUsingComparer();
            SortingUsingGenericComparer();
            SortingUsingDelegate();
            SortingUsingLambdaExpression();
            SortingUsingLinqQueryExpressionSyntax();
            SortingUsingLinqExtensionMethod();
            Console.ReadKey();
        }
    }
}