using CheeseApp.Server.Contracts;
using CheeseApp.Server.DataRepositories;
using CheeseApp.Server.Services;
using cheeseria.Server.DataRepositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ICheeseService, CheeseService>();
builder.Services.AddTransient<ICheeseRepository, CheeseRepository>();


builder.Services.AddDbContext<ShopContext>(
    options => options.UseSqlServer("Server=sql,1433;Database=ShopDb;User=SA;Password=MyPass@word;Encrypt=false;TrustServerCertificate=true;"));


var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
