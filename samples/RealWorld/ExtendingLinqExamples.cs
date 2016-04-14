using System;
using System.Data.Entity;
using System.Linq;
using TheModel;

namespace RealWorld
{
    public class ExtendingLinqExamples
    {
        public static void Run()
        {
            Database.SetInitializer(new TheModelDbContextInitializer());

            using (var db = new TheModelDbContext())
            {
                var results = db.Customers.WereBornOn(new DateTime(1992, 7, 7))
                                          .ArePrefered()
                                          .ToList();

                foreach (var customer in results)
                    Console.WriteLine("{0} - {1}", customer.Name, customer.BirthDate);
            }
        }
    }
}