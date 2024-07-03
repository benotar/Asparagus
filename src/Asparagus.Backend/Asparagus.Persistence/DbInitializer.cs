namespace Asparagus.Persistence;

public class DbInitializer
{
    public static void Initialize(AsparagusDbContext context)
    {
        context.Database.EnsureCreated();
    }
}