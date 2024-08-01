// Data/VehicleContext.cs
using Microsoft.EntityFrameworkCore;
using VehicleSaleInventory.Models;

namespace VehicleSaleInventory.Data
{
    public class VehicleContext : DbContext
    {
        public VehicleContext(DbContextOptions<VehicleContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
