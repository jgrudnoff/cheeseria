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
            try
            {
                var items = await _cheeseService.GetCheeses();
                if (items.Count() == 0)
                {
                    return NotFound();
                }
                else 
                {
                    return Ok(items);
                }
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CheeseDTO>> GetCheeseById(int id)
        {
            try
            {
                var item = await _cheeseService.GetCheeseById(id);
                if (item == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(item);
                }
            }
            catch (Exception ex) 
            { 
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCheese(int id, CheeseDTO cheese)
        {
            try
            {
                _cheeseService.UpdateCheese(id, cheese);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCheese(int id)
        {
            try
            {
                _cheeseService.DeleteCheese(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
