using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TheModel
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString() => $"{Id} {Name}: {Price}";

        public static ArrayList GetSampleArrayList()
        {
            return new ArrayList
                             {
                                 new Product(1, "Prednisone", 10.58m),
                                 new Product(2, "Levothyroxine Sodium", 92.59m),
                                 new Product(3, "Sertraline HCl", 59.71m),
                                 new Product(4, "Folic Acid", 54.97m),
                                 new Product(5, "Amoxicillin", 13.71m),
                                 new Product(6, "Atenolol", 10.58m),
                                 new Product(7, "Alprazolam", 29.17m),
                                 new Product(8, "Omeprazole (Rx)", 65.23m),
                                 new Product(9, "Furosemide", 70.82m),
                                 new Product(10, "Gabapentin", 60.90m)
                             };
        }

        public static List<Product> GetSampleGenericList()
        {
            return GetSampleArrayList().Cast<Product>().ToList();
        }
    }
}