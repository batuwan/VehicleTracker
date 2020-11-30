using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.Model;

namespace VehicleTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleMove> VehicleMoves { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<ZoneRecord> ZoneRecords { get; set; }
    }
}
