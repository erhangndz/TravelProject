using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ERHAN\\SQLEXPRESS;initial catalog=DbTravel;integrated security=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactPageInfo> ContactPageInfos { get; set; }
        
    }
}
