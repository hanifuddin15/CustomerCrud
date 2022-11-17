using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;

namespace CustomerCrud.Models
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext()
        {

        }
        public CustomerDbContext(DbContextOptions<CustomerDbContext>options): base(options)
        {

        }
        public DbSet <Customer> customers { get; set; }
        public DbSet <CustomerPermanentAddresses> customerPermanentAddresses { get; set; }
        //public DbSet<CustomerJointAddress> customerJointAddresses { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<CustomerJointAddress>()
        //        .HasKey(pc => new { pc.CustomerId, pc.CustomerPermanentAddressId });
        //    modelBuilder.Entity<CustomerJointAddress>()
        //        .HasOne(p => p.Customer);
        //        //.WithMany(pc => pc.CustomerP)
        //        //.HasForeignKey(p => p.Customer);
        //}
            //protected override void OnModelCreating(ModelBuilder modelBuilder)
            //{
            //    modelBuilder.Entity<CustomerPermanentAddress>()
            //        .HasKey(p=> new { p.CustomerID });
            //}
        }
}
 