using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop.Application.Abstractions;
using Shop.Domain.Entities;
using Shop.Domain.Entities.Auth;
using System.Reflection;

namespace Shop.Infrastructure.Persistance
{
    public class ShopDbContext : IdentityDbContext<User, Role, Guid>, IApplicationDbContext
    {
        public ShopDbContext(DbContextOptions options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Product> Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        async ValueTask<int> IApplicationDbContext.SaveChangesAsync(CancellationToken cancellationToken)
        {
            int res = await SaveChangesAsync(cancellationToken);
            return res; 
        }
    }
}
