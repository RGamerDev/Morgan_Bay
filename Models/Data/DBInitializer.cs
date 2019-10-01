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

            if (context.Clients.Any())
            {
                return;
            }

            Client[] clients = new Client[]
            {
                new Client{},
                new Client{},
                new Client{},
                new Client{},
                new Client{}
            };

            foreach (Client c in clients)
            {
                context.Clients.Add(c);
            }

            context.SaveChanges();

            Reservation[] reservations = new Reservation[]
            {
                new Reservation{},
                new Reservation{},
                new Reservation{},
                new Reservation{},
                new Reservation{}
            };

            foreach (Reservation r in reservations)
            {
                context.Reservations.Add(r);
            }

            context.SaveChanges();
        }
    }
}
