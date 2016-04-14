using System;
using System.Data.Entity;
using System.Linq;
using TheModel;

namespace RealWorld
{
    public class SortByAgeEFExample
    {
        public static void SortByAge()
        {
            Database.SetInitializer(new TheModelDbContextInitializer());
            using (var db = new TheModelDbContext())
            {
                db.Database.Log = Console.WriteLine;
                var sortByAge = db.Customers.OrderByDescending(c => c.BirthDate)
                                            .Select(c => new
                                            {
                                                Name = c.Name,
                                                Age = DbFunctions.DiffYears(c.BirthDate, DateTime.Now)
                                            })
                                            .ToList();

                foreach (var customer in sortByAge)
                    Console.WriteLine("{0} - {1}", customer.Name, customer.Age);
            }
        }
    }
}