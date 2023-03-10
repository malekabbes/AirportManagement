using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class PassangerConfiguration : IEntityTypeConfiguration<Passanger>
    {
        void IEntityTypeConfiguration<Passanger>.Configure(EntityTypeBuilder<Passanger> builder)
        {
            builder.OwnsOne(f => f.fullname, p =>
            {
            p.Property(f => f.FirstName).HasColumnName("FirstName").HasMaxLength(20).HasColumnType("varchar");
            p.Property(f => f.LastName).HasColumnName("LastName").HasMaxLength(20).HasColumnType("varchar");
            });
        }
    }
}
