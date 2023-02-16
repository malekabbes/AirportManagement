using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;

namespace AM.Infrastructure
{
    public class AmContext : DbContext
    {
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
