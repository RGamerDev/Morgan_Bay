using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Morgan_Bay.Models.Data
{
    public class DBInitializer
    {
        public void Initialize(BookingContext context)
        {
            context.Database.EnsureCreated();

            if (context.customers.Any())
            {
                return;
            }

            Customer[] customers = new Customer[]
            {
                new Customer{},
                new Customer{},
                new Customer{},
                new Customer{},
                new Customer{}
            };

            foreach (Customer c in customers)
            {
                context.customers.Add(c);
            }

            context.SaveChanges();

            Booking[] bookings = new Booking[]
            {
                new Booking{},
                new Booking{},
                new Booking{},
                new Booking{},
                new Booking{}
            };

            foreach (Booking r in bookings)
            {
                context.bookings.Add(r);
            }

            context.SaveChanges();
        }
    }
}
