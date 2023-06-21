using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICustomerControl
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        public int id { get; set; }
        [StringLength(25)]
        public string name { get; set; }
        [StringLength(25)]
        public string telephone { get; set; }
    }
}
