using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configuration;

namespace AM.Infrastructure
{
    
    public class AmContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfiguration(new Flightconfiguration());
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            modelBuilder.ApplyConfiguration(new PassangerConfiguration());
            //modelBuilder.Entity<Passanger>().Property(f => f.fullname.FirstName)
            //    .HasColumnName("PassangerName")
            //    .HasMaxLength(50)
            //    .IsRequired()
            //    .HasColumnType("varchar");
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(50);
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<Double>().HavePrecision(2,3);
        }
        public DbSet<Flight> Flights { get; set; } 
        public DbSet<Passanger> Passangers { get; set; }
        public DbSet<Traveller> Traveller { get; set; }
        public DbSet<Staff> Staff { get; set; }

        public DbSet<Plane> Plane { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=(localdb)\mssqllocaldb;initial catalog=MalekAbbes;integrated security=true");
        }
    }
}
