using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("Topics")]
    public class Topic
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="nvarchar")]
        [StringLength(50)]
        public string TopicName { get; set; }
        public virtual IEnumerable<Category> Categories { get; set; }

    }
}
