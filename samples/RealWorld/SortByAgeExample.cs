using System;
using System.Linq;
using TheModel;

namespace RealWorld
{
    public class SortByAgeExample
    {
        private static int GetAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;
            return age;
        }

        public static void SortByAge()
        {
            var customers = Customer.GetSampleGenericList();

            var sortByAge = customers.OrderByDescending(c => c.BirthDate)
                                     .Select(c => new
                                     {
                                         Name = c.Name,
                                         Age = GetAge(c.BirthDate)
                                     });

            foreach (var customer in sortByAge)
                Console.WriteLine("{0} - {1}", customer.Name, customer.Age);
        }
    }
}