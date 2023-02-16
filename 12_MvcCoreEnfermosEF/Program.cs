using _12_MvcCoreEnfermosEF.Data;
using _12_MvcCoreEnfermosEF.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connectionString = builder.Configuration.GetConnectionString("SqlEnfermo");
builder.Services.AddTransient<RepositoryEnfermo>();
builder.Services.AddDbContext<EnfermoContext>(options => options.UseSqlServer(connectionString));

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
    pattern: "{controller=Enfermo}/{action=Index}/{id?}");

app.Run();
