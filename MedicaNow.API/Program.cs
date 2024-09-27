using MedicaNow.Core.System;
using MedicaNow.Persistence.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MedicaNowContext>(options =>
{
    if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
    {
        options.UseSqlServer(ConnectionStrings.LocalConnectionString, builder => builder.MigrationsAssembly("FKA.Persistence"));
    }
    else // In Development Environment
    {
        options.UseSqlServer(ConnectionStrings.LocalConnectionString, builder => builder.MigrationsAssembly("MedicaNow.Persistence"));
    }
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
