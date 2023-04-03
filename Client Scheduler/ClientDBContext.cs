using Client_Scheduler.Models;
using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;

namespace Client_Scheduler
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class ClientDBContext : DbContext
    {
        public ClientDBContext()
            : base("ConnectionString")
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //map tables using fluent API of entity framework EF 6
            modelBuilder.Entity<Customer>().ToTable("Customer").Ignore(e => e.address);
            modelBuilder.Entity<Address>().ToTable("Address").Ignore(e => e.city);
            modelBuilder.Entity<City>().ToTable("City").Ignore(e => e.country);
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<Appointment>().ToTable("Appointment");
            modelBuilder.Entity<User>().ToTable("User");
        }
        //Setting default date values for lastUpdate and createDate
        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).lastUpdate = DateTime.Now.ToUniversalTime();

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).createDate = DateTime.Now.ToUniversalTime();
                }
            }

            return base.SaveChanges();
        }
    }
}
