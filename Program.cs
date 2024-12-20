using FEH.Components;
using FEH.Components.Pages.MessagingPages;
using FEH.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FEH.Data;
<<<<<<< HEAD
using FEH.State;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<JackContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("JackContext") ?? throw new InvalidOperationException("Connection string 'JackContext' not found.")));


=======

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<FEHContext1>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FEHContext1") ?? throw new InvalidOperationException("Connection string 'FEHContext1' not found.")));
>>>>>>> not-working

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
<<<<<<< HEAD
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSingleton<Messaging>();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
=======
>>>>>>> not-working

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

app.UseSession();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
