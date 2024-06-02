using CheeseApp.Server.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CheeseApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CheeseController : ControllerBase
    {

        private readonly ILogger<CheeseController> _logger;
        ICheeseService _cheeseService;

        public CheeseController(ILogger<CheeseController> logger, ICheeseService productService)
        {
            _cheeseService = productService;
            _logger = logger;
        }

        [HttpGet(Name = "GetCheese")]
        public async Task<ActionResult<IEnumerable<CheeseDTO>>> Get()
        {
            return Ok(await _cheeseService.GetCheeses());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CheeseDTO>> GetCheeseById(int id)
        {
            var cheese = await _cheeseService.GetCheeseById(id);
            if (cheese != null) 
            { 
                return Ok(cheese); 
            } else
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCheese(int id, CheeseDTO cheese)
        {
            _cheeseService.UpdateCheese(id, cheese);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<CheeseDTO>> PostCheese(CheeseDTO cheese)
        {
            var newCheese = await _cheeseService.InsertCheese(cheese);
            if (newCheese != null)
            {
                return Ok(newCheese);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCheese(int id)
        {
            _cheeseService.DeleteCheese(id);
            return NoContent();
        }
    }
}
