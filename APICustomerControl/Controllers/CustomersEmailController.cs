using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICustomerControl.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersEmailController : Controller
    {
        private readonly APICustomerControlContext _context;
        private readonly IConfiguration _configuration;

        public CustomersEmailController(APICustomerControlContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpGet("listaCustomerEmail")]
        public async Task<IActionResult> listaCustomerEmail()
        {
            var valores = Util.Utilidade.readConfiguration();
            var teste1 = valores.porta;


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
