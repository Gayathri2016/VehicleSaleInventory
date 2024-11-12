// Data/VehicleContext.cs
using Microsoft.EntityFrameworkCore;
using VehicleSaleInventory.Models;

namespace VehicleSaleInventory.Data
{
    public class VehicleContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            var generator = new DataGeneartor();
            modelBuilder.Entity<Vehicle>().HasData(generator.GenerateVehicles(100));
        }
        public VehicleContext(DbContextOptions<VehicleContext> options)
            : base(options)
        {
            
        }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
