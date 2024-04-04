using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(x => x.Type)
                .IsRequired()
                .HasMaxLength(10);

            builder.HasData(new Product[]
                {
                    new Product { Id = 1,Name = "Moloko",Type = "achigan"},
                    new Product { Id = 2,Name = "sut",Type = "bunisiyam"}

            });
        }
        
    }
}
