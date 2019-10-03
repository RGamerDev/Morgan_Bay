using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Morgan_Bay.Models.Data
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options) : base(options){}

        public DbSet<Customer> customers { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Employee> employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<Room>().ToTable("Room");
            modelBuilder.Entity<Payment>().ToTable("Payment");
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }
}
