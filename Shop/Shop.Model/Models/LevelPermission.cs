using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("LevelPermissions")]
    public class LevelPermission
    {
        public int Id { get; set; }
        [Required]
        public int LevelId { get; set; }
        [ForeignKey("LevelId")]
        public virtual Level Level { get; set; }
        [Required]
        [Column(TypeName ="nvarchar")]
        [StringLength(50)]
        public string TableName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string DisplayName { get; set; }
        [Required]
        [Column(TypeName ="bit")]
        public bool AllowAdd { get; set; }
        [Required]
        [Column(TypeName = "bit")]
        public bool AllowEdit { get; set; }
        [Required]
        [Column(TypeName = "bit")]
        public bool AllowDelete { get; set; }
        [Required]
        [Column(TypeName = "bit")]
        public bool AllowView { get; set; }
        [Required]
        [Column(TypeName = "bit")]
        public bool FullList { get; set; }



    }
}
