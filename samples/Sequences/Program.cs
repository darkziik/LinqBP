using System;
using System.Collections.Generic;
using System.Linq;

namespace Sequences
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Iterator Design Pattern:
            // Provide a way to access the elements of an aggregate object sequentially 
            // without exposing its underlying representation.

            // In C# the iterator pattern is encapsulated by the IEnumerable & IEnumerable<T> interfaces.
            IEnumerable<string> cities = new List<string>
            {
                "Barranquilla",
                "Bogotá",
                "Bucaramanga",
                "Cartagena",
                "Cali",
                "Medellín",
                "Santa Marta",
                "Valledupar"
            };

            IEnumerable<string> citiesThatStarsWithC1 = from c in cities
                                                        where c.StartsWith("C")
                                                        select c;

            IEnumerable<string> citiesThatStarsWithC2 = cities.Where(c => c.StartsWith("C"));

            // Iterator Design Pattern
            using (IEnumerator<string> enumerator = cities.GetEnumerator())
                while (enumerator.MoveNext())
                    Console.WriteLine(enumerator.Current);

            // Built-in support for consuming iterators using the foreach statement.
            foreach (string city in cities)
                Console.WriteLine(city);

            Console.ReadKey();
        }
    }
}