using ASP.Net_Project_2.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_Project_2.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) { }

        //give inital value for our serial number and item in our database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item { Id= 4, Name= "microphone", Price=40, SerialNumberId= 10}
                );
            modelBuilder.Entity<SerialNumber>().HasData(
                new SerialNumber { Id = 10, Name = "RIC150",ItemId=4 }
                );
            base.OnModelCreating(modelBuilder);
        }
        //these are the database instance to create tables in DB.
        public DbSet<Item> Items { get; set; }
        public DbSet<SerialNumber> SerialNumbers { get; set; }
    }
}
