using helperland.Models;
using helperland.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<HelperlandContext>(
    options => options.UseSqlServer("Server=.;Database=Helperland;Integrated Security=True;"));
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<HelperlandContext>();
builder.Services.AddScoped<ContactRepository, ContactRepository>();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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

app.Run();