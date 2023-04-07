using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        void IEntityTypeConfiguration<Ticket>.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Ticket> builder)
        {
        builder.ToTable("Table_Ticket");
            builder.HasKey(t => new {t.PassengerFK,t.FlightFK });
            builder.HasOne(t => t.passangerProp).WithMany(p => p.ticket).HasForeignKey(t => t.PassengerFK);
            builder.HasOne(t => t.flightProp).WithMany(f => f.ticket).HasForeignKey(t => t.FlightFK);
        }
    }
}
