using CheeseApp.Server.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CheeseApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CheeseController : ControllerBase
    {

        private readonly ILogger<CheeseController> _logger;
        IProductService _productService;

        public CheeseController(ILogger<CheeseController> logger, IProductService productService)
        {
            _productService = productService;
            _logger = logger;
        }

        [HttpGet(Name = "GetCheese")]
        public IEnumerable<Cheese> Get()
        {
            return (IEnumerable<Cheese>)_productService.GetAllProducts();
        }
    }
}
