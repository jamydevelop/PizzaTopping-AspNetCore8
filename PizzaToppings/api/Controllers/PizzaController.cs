using api.Data;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/pizza")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public PizzaController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var pizza = _context.Pizzas.ToList();
            return Ok(pizza);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var pizzaById = _context.Pizzas.Find(id);
            return Ok(pizzaById);
        }
    }
}