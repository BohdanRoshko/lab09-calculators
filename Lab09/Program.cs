using System.Configuration;
using Data;
using Lab09.Components;
using Lab09.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IGetLatestOperations, GetLatestOperations>();
builder.Services.AddScoped<ISaveOperation, SaveOperation>();
//Data layer
//builder.Services.AddSingleton<IDataAccess, DataAccess>();
builder.Services.AddDbContext<Context>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")))); // Make sure the version matches your MySQL server version

builder.Services.AddBlazorBootstrap();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseRouting();  // Ensure UseRouting is called here

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapRazorComponents<App>()
        .AddInteractiveServerRenderMode();

    // Logging all endpoints
    foreach (var endpoint in endpoints.DataSources.SelectMany(src => src.Endpoints))
    {
        var routeEndpoint = endpoint as RouteEndpoint;
        Console.WriteLine($"Route: {routeEndpoint?.RoutePattern.RawText}, Endpoint: {endpoint.DisplayName}");
    }
});

app.Run();
