using Microsoft.EntityFrameworkCore;
using WeatherAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("default");
builder.Services.AddDbContext<WeatherContext>(c => c.UseSqlite(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var myPolicy = "allowAnyOrigin";
builder.Services.AddCors(options =>
{
    options.AddPolicy(myPolicy,builder => {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(myPolicy);
}

app.UseAuthorization();

app.MapControllers();
app.Run();
