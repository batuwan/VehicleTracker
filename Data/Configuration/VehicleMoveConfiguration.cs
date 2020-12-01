using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.Model;

namespace VehicleTracker.Data.Configuration
{
    public class VehicleMoveConfiguration : IEntityTypeConfiguration<VehicleMove>
    {
        public void Configure(EntityTypeBuilder<VehicleMove> builder)
        {   
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            //TODO
            builder.Property(x => x.Geom).IsRequired();
            builder.Property(x => x.VehicleId).IsRequired();
            builder.Property(x => x.Date_).IsRequired(); 
            builder.Property(x => x.Velocity);

            builder.ToTable("VehicleMoves");

        }
    }
}
