using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class Flightconfiguration : IEntityTypeConfiguration<Flight>
    {
        void IEntityTypeConfiguration<Flight>.Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.ToTable("Table_Flight");
            builder.HasKey(f => f.FlightId);
            builder.HasMany(f => f.passangers).WithMany(p => p.flights).UsingEntity(p=>p.ToTable("Table_PassangerFlight"));
            builder.HasOne(f=>f.plane).WithMany(p=>p.flights).HasForeignKey(f=>f.PlaneId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
