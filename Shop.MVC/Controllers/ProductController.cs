using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.useCases.Products.Queries;

namespace Shop.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public IActionResult Index()
        {
            var res = _mediator.Send(new GetAllProductsQuery());
            return View(res);
        }
    }
}
