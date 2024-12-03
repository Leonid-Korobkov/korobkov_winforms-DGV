using DGV.Standart.Manager;
using DGV.Storage.Database;
using Serilog.Extensions.Logging;
using Serilog;
using DGV.Standart.Contracts;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Настройка Serilog
var serilogLogger = new LoggerConfiguration()
    .MinimumLevel.Verbose()
    .WriteTo.Seq("http://localhost:5341/", apiKey: "mudhnSNLQJrgaLSZPuuw")
    .CreateLogger();

// Установка логгера Serilog
builder.Host.UseSerilog(serilogLogger);

// Регистрация зависимостей
builder.Services.AddSingleton<ILoggerFactory>(new SerilogLoggerFactory(serilogLogger));
builder.Services.AddSingleton<Microsoft.Extensions.Logging.ILogger>(sp => sp.GetRequiredService<ILoggerFactory>().CreateLogger("aspnet-mvc"));

// Регистрация хранилища и менеджера
builder.Services.AddSingleton<ITourStorage, DBTour>();
builder.Services.AddTransient<TourManager>();
var connectionString = builder.Configuration.GetConnectionString("DBConnection");
Console.WriteLine(connectionString);


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Tour}/{action=Index}/{id?}");

app.Run();
