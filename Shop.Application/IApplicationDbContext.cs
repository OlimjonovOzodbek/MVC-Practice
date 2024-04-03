using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application
{
    public interface IApplicationDbContext
    {
        public DbSet<Product> Products {  get; set; }
        ValueTask<Product> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
