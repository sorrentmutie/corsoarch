using DemoLibreria;
using DemoLibreria.Interfaces;
using DemoWeb.Data;
using DemoWeb.Interfaces;
using DemoWeb.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<NorthwindContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Northwind")));

builder.Services.AddScoped<IA, A>();
builder.Services.AddScoped<IB, B>();
builder.Services.AddScoped<IMessageWriter, MessageWriter>();
//builder.Services.AddScoped<ICategoriesData, NorthwindCategoriesData>();

//builder.Services.AddScoped<IData<Category, CategoriaDTO, int>, GenericNorthwindData<Category, CategoriaDTO, int>>();
//builder.Services.AddScoped<IData<Product, ProductDTO, int>, GenericNorthwindData<Product, ProductDTO, int>>();
builder.Services.AddScoped<UnitOfWork>();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
