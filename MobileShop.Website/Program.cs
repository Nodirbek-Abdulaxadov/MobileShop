using Microsoft.EntityFrameworkCore;
using MobileShop.Data;
using MobileShop.Service.Interfaces;
using MobileShop.Service.Repositories;
using MobileShop.Website.Services;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IBrandInterface, BrandRepository>();
builder.Services.AddTransient<IProductInterface, ProductRepository>();
builder.Services.AddTransient<IFileInterface, FileRepository>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDB")));

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
    pattern: "{controller=home}/{action=Index}/{id?}");

app.Run();
