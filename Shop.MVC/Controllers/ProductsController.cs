using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.useCases.Products.Queries;

namespace Shop.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {
            var res = await _mediator.Send(new GetAllProductsQuery());
            return View(res);
        }
    }
}
