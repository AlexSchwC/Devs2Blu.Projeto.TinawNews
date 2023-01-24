using Devs2Blu.Projeto.TinawNews.Application.Services.SQLServerServices;
using Devs2Blu.Projeto.TinawNews.Domain.IRepositories;
using Devs2Blu.Projeto.TinawNews.Domain.IServices;
using Devs2Blu.Projeto.TinawNews.Infra.Data.Context;
using Devs2Blu.Projeto.TinawNews.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);   

// Add services to the container.
builder.Services.AddControllersWithViews();

// Context SQLServer
builder.Services.AddDbContext<SQLServerContext>
    // Notebook
    (options => options.UseSqlServer("Server=DESKTOP-STUVV70\\SQLEXPRESS;Database=TinawNews;User Id=sa;Password=admin;Encrypt=False;"));
    // PC - Casa
    //(options => options.UseSqlServer("Server=DESKTOP-J7S4R36\\SQLEXPRESS;Database=TinawNews;User Id=sa;Password=admin;Encrypt=False;"));

// ## Dependency Injection
// # Repositories
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<INewsRepository, NewsRepository>();

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<INewsService, NewsService>();

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
