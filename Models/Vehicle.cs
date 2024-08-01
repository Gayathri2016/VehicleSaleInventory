using System;
using System.Diagnostics.Contracts;
namespace VehicleSaleInventory.Models
{
    public class Vehicle{
        public int Id {get;set;}
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string VIN { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
