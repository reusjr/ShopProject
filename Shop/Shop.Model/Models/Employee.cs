using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("Employees")]
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="nvarchar")]
        [StringLength(50)]
        [Index(IsUnique =true)]
        public string LoginName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string EmployeeName { get; set; }
        [Column(TypeName = "nchar")]
        [StringLength(20)]
        public string Phone { get; set; }
        [Column(TypeName = "nchar")]
        [StringLength(200)]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(200)]
        public string Address { get; set; }

        public int LevelId { get; set; }
        [ForeignKey("LevelId")]
        public virtual Level Level { get; set; }
        public DateTime LastLogin { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
