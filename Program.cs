using FEH.Components;
using FEH.Components.Pages.MessagingPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FEH.Data;
using FEH.State;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<JackContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("JackContext") ?? throw new InvalidOperationException("Connection string 'JackContext' not found.")));



var builder1 = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<FEHContext1>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FEHContext1") ?? throw new InvalidOperationException("Connection string 'FEHContext1' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSingleton<Messaging>();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


builder1.Services.AddDbContextFactory<FEHContext1>(options =>
    options.UseSqlServer(builder1.Configuration.GetConnectionString("FEHContext1") ?? throw new InvalidOperationException("Connection string 'FEHContext1' not found.")));

builder1.Services.AddQuickGridEntityFrameworkAdapter();

builder1.Services.AddDatabaseDeveloperPageExceptionFilter();
builder1.Services.AddDistributedMemoryCache();

builder1.Services.AddSingleton<Messaging>();

builder1.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
// Add services to the container.
builder1.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();
var app1 = builder1.Build();
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

app.UseSession();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
if (!app1.Environment.IsDevelopment())
{
    app1.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app1.UseHsts();
    app1.UseMigrationsEndPoint();
}

app1.UseHttpsRedirection();

app1.UseStaticFiles();
app1.UseAntiforgery();

app1.UseSession();

app1.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app1.Run();
