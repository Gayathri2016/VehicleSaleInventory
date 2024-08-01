using System.Security.Cryptography;
using VehicleSaleInventory;
using VehicleSaleInventory.Data;



var builder = WebApplication.CreateBuilder(args);
var Startup = new Startup(builder.Configuration);
Startup.ConfigureServices(builder.Services);
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

var env = builder.Environment;
Startup.Configure(app, env);
app.Run();



