
using FreelancerClientTracker.Components;
using FreelancerClientTracker.Data;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 🔷 1. Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// 🔷 2. Add Database Connection
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

var app = builder.Build();

// 🔷 3. Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

// 🔷 4. Antiforgery is important for Blazor Forms
app.UseAntiforgery();

app.MapStaticAssets();

// 🔷 5. Map the components and enable the Render Mode
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();