using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infrastructure.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            //many to many + rename table
            builder.HasMany(f => f.Passengers).WithMany(p => p.Flights).UsingEntity(t => t.ToTable("RelationPassengerFlight"));

            builder.HasOne(f => f.Plane).WithMany(p => p.Flights)// 2eme methode khater aamlinha annotation.HasForeignKey(f => f.planefk)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
