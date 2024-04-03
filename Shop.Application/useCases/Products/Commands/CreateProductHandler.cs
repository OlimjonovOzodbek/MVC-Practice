using Mapster;
using MediatR;
using Shop.Application.Abstractions;
using Shop.Application.useCases.Products.Queries;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.useCases.Products.Commands
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly IApplicationDbContext _context;

        public CreateProductHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = request.Adapt<Product>();
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync(cancellationToken);
            return product;

        }
    }
}
