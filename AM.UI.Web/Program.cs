using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IServiceFlight, ServiceFlight>();
builder.Services.AddScoped<IServicePlane, ServicePlane>();
//IServiceFlight service = new ServiceFlight(uow);
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
//IUnitOfWork UOW = new UnitOfWork(DbContext,AmContext);
builder.Services.AddDbContext<DbContext,AmContext>();
//DbContext dbContext = new AmContext();
builder.Services
    .AddSingleton<Type>(p => typeof(GenericRepository<>));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Privacy}/{id?}");

app.Run();
