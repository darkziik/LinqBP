using System;
using System.Collections.Generic;
using System.Linq;

namespace TheModel
{
    public class Customer
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool IsPrefered { get; private set; }

        private Customer() { }

        public Customer(int id, string name, DateTime birthDate, bool isPrefered)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            IsPrefered = isPrefered;
        }

        #region Others

        public override string ToString() => $"{Id}: {Name} - {BirthDate}";

        public static List<Customer> GetSampleGenericList()
        {
            return new List<Customer>
                   {
                       new Customer(1, "Jerry", new DateTime(1980, 1, 1),false),
                       new Customer(2, "Mason", new DateTime(1970, 2, 2),false),
                       new Customer(3, "Avye", new DateTime(1990, 3, 3),true),
                       new Customer(4, "Olga", new DateTime(1985, 4, 4),false),
                       new Customer(5, "Kirsten", new DateTime(1995, 5, 5),true),
                       new Customer(6, "Kim", new DateTime(1988, 6, 6),false),
                       new Customer(7, "Cally", new DateTime(1992, 7, 7),true),
                       new Customer(8, "Phillip", new DateTime(1979, 8, 8),false),
                       new Customer(9, "Melanie", new DateTime(1987, 9, 9),true),
                       new Customer(10, "Dominique", new DateTime(1981, 10, 10),false),
                   };
        }

        #endregion
    }

    #region Specifications

    public static class CustomerSpecifications
    {
        public static IQueryable<Customer> ArePrefered(this IQueryable<Customer> customers) => customers.Where(c => c.IsPrefered);

        public static IQueryable<Customer> WereBornOn(this IQueryable<Customer> customers, DateTime date) => customers.Where(c => c.BirthDate == date);
    }

    #endregion
}