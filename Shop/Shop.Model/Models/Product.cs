using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(150)]
        public string ProductName { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Unit { get; set; }
        [Required]
        [Column(TypeName = "decimal")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        //public int PictureId { get; set; }
        //[ForeignKey("PictureId")]
        //public virtual Picture Picture { get; set; }
        public virtual IEnumerable<Picture> Pictures { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
