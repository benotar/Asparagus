using Asparagus.Persistence;

var builder = WebApplication.CreateBuilder();

builder.Services.AddControllersWithViews();

builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin();
    });
});

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;

    try
    {
        var context = serviceProvider.GetRequiredService<AsparagusDbContext>();

        DbInitializer.Initialize(context);
    }
    catch (Exception ex)
    {
        
    }
}

app.UseRouting();

app.UseAuthorization();

app.UseCors("AllowAll");

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();