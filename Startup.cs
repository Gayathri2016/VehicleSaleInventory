using Microsoft.EntityFrameworkCore;
using VehicleSaleInventory.Data;
using Microsoft.Extensions.Configuration;

namespace VehicleSaleInventory;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddDbContext<VehicleContext>(options =>
            options.UseSqlServer(Microsoft.Extensions.Configuration.ConfigurationExtensions.GetConnectionString(Configuration, "DefaultConnection")));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
