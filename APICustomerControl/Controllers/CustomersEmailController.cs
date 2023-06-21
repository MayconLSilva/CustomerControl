using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICustomerControl.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersEmailController : Controller
    {
        private readonly APICustomerControlContext _context;

        public CustomersEmailController(APICustomerControlContext context)
        {
            _context = context;
        }

        [HttpGet("listaCustomerEmail")]
        public async Task<IActionResult> listaCustomerEmail()
        {
            var trazDados = await _context.CustomersEmail.ToListAsync();

            return Ok(trazDados);
        }

        [HttpPost("insertCustomerEmail")]
        public async Task<IActionResult> insertCustomerEmail(CustomerEmailGeral customer)
        {
            var customerEmail = new CustomerEmail()
            {
                email = customer.email,
                contato = customer.contato,
                idExt = customer.idExt

            };


            var inserirObjetos = _context.CustomersEmail.Add(customerEmail);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
