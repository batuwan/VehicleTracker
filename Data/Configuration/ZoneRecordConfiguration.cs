using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.Model;

namespace VehicleTracker.Data.Configuration
{
    public class ZoneRecordConfiguration : IEntityTypeConfiguration<ZoneRecord>
    {
        public void Configure(EntityTypeBuilder<ZoneRecord> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Date_);
            builder.Property(x => x.VehicleId).IsRequired();
            builder.Property(x => x.VehicleMoveId).IsRequired();
            builder.Property(x => x.ZoneId).IsRequired();
            builder.Property(x => x.RecordType);

            builder.ToTable("ZoneRecords");

        }
    }
}
