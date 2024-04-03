using Shop.Domain.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;
using System.Reflection;

namespace Shop.Infrastructure.Persistance
{
    public class ShopDbContext : IdentityDbContext<User, Role, Guid>
    {
        public ShopDbContext(DbContextOptions options)
            :base(options)
        {
            Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
