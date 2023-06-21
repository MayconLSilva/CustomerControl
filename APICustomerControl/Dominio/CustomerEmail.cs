using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace APICustomerControl
{
    [Table("customeremail")]
    public class CustomerEmail
    {
        [Key]
        public int id { get; set; }
        [StringLength(25)]
        public string email { get; set; }
        [StringLength(25)]
        public string contato { get; set; }

        [ForeignKey("Customer")]
        public int idExt { get; set; }
        [JsonIgnore]
        public Customer Customer { get; set; }
    }
}
