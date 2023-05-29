using DemoTraveler.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoTraveler.Models.ViewModels;

namespace DemoTraveler.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<HomeImage> HomeImages { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingPackage> BookingPackages { get; set; }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<FlightType> FlightTypes { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentPackage> PaymentPackages { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<UserTicket> UserTickets { get; set; }
        public DbSet<UserPackage> UserPackages { get; set; }

    }
}
