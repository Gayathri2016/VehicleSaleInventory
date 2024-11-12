using Bogus;
using VehicleSaleInventory.Models;

namespace VehicleSaleInventory.Data;

public class DataGeneartor
{
    private static List<Vehicle> GetVehicleGenerator(int numberOfVehicles)
    {
        var vehicleFaker = new Faker<Vehicle>()
             .RuleFor(v => v.Id, f => f.IndexFaker + 1)
             .RuleFor(v => v.Make, f => f.Vehicle.Manufacturer())
             .RuleFor(v => v.Model, f => f.Vehicle.Model())
             .RuleFor(v => v.Year, f => f.Date.Past(20).Year)
             .RuleFor(v => v.Price, f => f.Finance.Amount(5000, 50000))
             .RuleFor(v => v.VIN, f => f.Vehicle.Vin())
             .RuleFor(v => v.DateAdded, f => f.Date.Past(1));

        return vehicleFaker.Generate(numberOfVehicles);
    }

    internal Vehicle[] GenerateVehicles(int v)
    {
        throw new NotImplementedException();
    }
}
