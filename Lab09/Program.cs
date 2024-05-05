using Data;
using Lab09.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddControllersWithViews();
builder.Services.AddServerSideBlazor();

//Data layer
builder.Services.AddSingleton<IDataAccess, DataAccess>();

builder.Services.AddBlazorBootstrap();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapControllers();  // Map controller routes
app.MapBlazorHub();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
