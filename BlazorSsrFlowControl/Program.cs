using BlazorServerProductionControl.Services;
using BlazorSsrFlowControl.Components;
using BlazorSsrFlowControl.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();
builder.Services.AddControllers();

builder.Services.AddSingleton<AuthenticationService>();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlite("Data Source=FlowControlDb.db"));

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
    dbContext.Database.EnsureCreated();
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapControllers();
app.MapRazorComponents<App>();

app.Run();
