using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Proiect5.Data;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages((options =>
{
    options.Conventions.AuthorizeFolder("/Profesori");
    options.Conventions.AllowAnonymousToPage("/Profesori/Index");
    options.Conventions.AllowAnonymousToPage("/Profesori/Details");


}));
builder.Services.AddDbContext<Proiect5Context>(options =>

options.UseSqlServer(builder.Configuration.GetConnectionString("Proiect5Context") ?? throw new InvalidOperationException("Proiect5Context' not found.")));
builder.Services.AddDbContext<AutentificareContext>(options =>

options.UseSqlServer(builder.Configuration.GetConnectionString("Proiect5Context") ?? throw new InvalidOperationException("Connectionstring 'Proiect5Context' not found.")));
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
 .AddEntityFrameworkStores<AutentificareContext>();
var app = builder.Build(); if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
