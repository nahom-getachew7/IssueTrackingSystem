using Microsoft.EntityFrameworkCore;
using LicenseManagementService.Models;
using JwtAuthenticationManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<LicenseContext>(options =>
options.UseMySQL(builder.Configuration.GetConnectionString("License"))
);

builder.Services.AddControllers();
builder.Services.AddCustomJwtAuthentication();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
