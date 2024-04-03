using MediatR;
using Shop.Application.Abstractions;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.useCases.Products.Commands
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Product>
    {
        private readonly IApplicationDbContext _context;
        public DeleteProductCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        async Task<Product> IRequestHandler<DeleteProductCommand, Product>.Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var check = _context.Products.FirstOrDefault(x => x.Id == request.Id);
            if (check == null)
            {
                throw new Exception("Not Found");
            }
            _context.Products.Remove(check);
            await _context.SaveChangesAsync(cancellationToken);
            return check;
        }
    }
}
