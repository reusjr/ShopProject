using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("Levels")]
    public class Level
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="nvarchar")]
        [StringLength(50)]
        public string LevelName { get; set; }
        public virtual IEnumerable<Employee> Employees { get; set; }
        public virtual IEnumerable<LevelPermission> LevelPermissions { get; set; }
    }
}
