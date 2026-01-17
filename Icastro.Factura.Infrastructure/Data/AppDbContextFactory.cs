using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Icastro.Factura.Infrastructure.Data
{
    public class AppDbContextFactory
        : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseNpgsql(
                "Host=db.bkdvugrycspqzbtzzbrz.supabase.co;" +
                "Port=5432;" +
                "Database=postgres;" +
                "Username=postgres;" +
                "Password=0941930661;" +
                "SSL Mode=Require;" +
                "Trust Server Certificate=true;"
            );

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
