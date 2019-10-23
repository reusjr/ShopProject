using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        public int Id { get; set; }
        [Column(TypeName ="nvarchar")]
        [StringLength(20)]
        public string OrderCode { get; set;}
        [Required]
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
     
        public int ShippingId { get; set; }
        [ForeignKey("ShippingId")]
        public virtual Shipping Shipping { get; set; }
        [Required]
        public decimal Discount { get; set; }
        [Required]
        public decimal Tax { get; set; }
        [Required]
        public decimal ShippingFee { get; set; }
        public int PaymentMethodId { get; set; }
        [ForeignKey("PaymentMethodId")]
        public virtual PaymentMethod PaymentMethod { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
