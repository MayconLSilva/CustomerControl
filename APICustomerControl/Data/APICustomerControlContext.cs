using Microsoft.EntityFrameworkCore;

namespace APICustomerControl
{
    public class APICustomerControlContext : DbContext
    {
        public APICustomerControlContext(DbContextOptions<APICustomerControlContext> options)
            : base(options)
        {
        }

        public DbSet<APICustomerControl.Customer> Customer { get; set; } = default!;

        public DbSet<APICustomerControl.CustomerEmail> CustomersEmail { get; set; } = default!;
    }
}
