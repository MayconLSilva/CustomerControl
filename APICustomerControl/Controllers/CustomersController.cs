using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICustomerControl
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : Controller
    {
        private readonly APICustomerControlContext _context;

        public CustomersController(APICustomerControlContext context)
        {
            _context = context;
        }

        [HttpGet("listaCustomer")]
        public async Task<IActionResult> listaCustomer()
        {
            var trazDados = await _context.Customer.ToListAsync();

            return Ok(trazDados);
        }

        [HttpPost("insertCustomer")]
        public async Task<IActionResult> insertCustomer(Customer customer)
        {
            var inserirObjetos = _context.Customer.Add(customer);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
