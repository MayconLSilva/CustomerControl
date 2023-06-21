using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APICustomerControl
{
    [Table("customeremail")]
    public class CustomerEmailGeral
    {
        [Key]
        public int id { get; set; }
        [StringLength(25)]
        public string email { get; set; }
        [StringLength(25)]
        public string contato { get; set; }

        [ForeignKey("Customer")]
        public int idExt { get; set; }
    }
}
