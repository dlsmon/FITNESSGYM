using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using FITNESSGYM.Data;
using Microsoft.AspNetCore.Authorization;
using NuGet.Protocol.Plugins;
using System.Security.Principal;
using FITNESSGYM.Models;
using Microsoft.Extensions.DependencyInjection;

//# Get Environment Variable
var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FITNESSGYMDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FITNESSGYMDBContextConnection") ?? throw new InvalidOperationException("Connection string 'FITNESSGYMDBContext' not found.")));
var connectionString = builder.Configuration.GetConnectionString("FITNESSGYMContextConnection") ?? throw new InvalidOperationException("Connection string 'FITNESSGYMContextConnection' not found.");

builder.Services.AddDbContext<FITNESSGYMContext>(options => options.UseSqlServer(connectionString));


builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<FITNESSGYMContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.MapRazorPages();

app.Run();
