using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaiAdmin.Models
{
    [Table("ReportInfo")]
    public partial class ReportInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [RegularExpression("[a-zA-Z0-9-_]+")]
        [Column("guid")]
        public string Guid { get; set; }

        [Required]
        [RegularExpression("[a-zA-Z0-9-_]+")]
        [Column("key")]
        public string Key { get; set; }
    }
}
