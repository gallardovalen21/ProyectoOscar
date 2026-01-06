using Clasess;
using Clasess.Services;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Usar SQL Server en lugar de SQLite
builder.Services.AddDbContext<SubDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("proyectoContext1"));
});
builder.Services.AddScoped<SubscriptionService>();
var app = builder.Build();

// Apply pending migrations and create the SQL Server database on startup
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<SubDbContext>();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
