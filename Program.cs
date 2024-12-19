using FEH.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OurDogs.Data;
using FEH;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<FEHContext1>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FEHContext1") ?? throw new InvalidOperationException("Connection string 'FEHContext1' not found.")));
builder.Services.AddDbContextFactory<FEHContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FEHContext") ?? throw new InvalidOperationException("Connection string 'FEHContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();