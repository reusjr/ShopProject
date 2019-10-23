using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("pictures")]
    public class Picture
    {
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        [ForeignKey(" ProductId")]
        public virtual Product Product {get;set;}
        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(250)]
        public string Url { get; set; }
        //public virtual IEnumerable<Product> Products { get; set; }
    }
}
