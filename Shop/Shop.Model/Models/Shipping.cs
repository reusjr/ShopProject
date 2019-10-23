using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("Shippings")]
    
    public class Shipping
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="nvarchar")]
        [StringLength(50)]
        public string ShippingName { get; set; }
        [Column(TypeName ="nvarchar")]
        [StringLength(150)]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Phone { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(200)]
        public string Address { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
