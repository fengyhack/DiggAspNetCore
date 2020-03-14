using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaiAdmin.Models
{
    [Table("ModelInfo")]
    public partial class ModelInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [RegularExpression("[a-zA-Z0-9-_]+")]
        [Column("type")]
        public string Type { get; set; }

        [Required]
        [RegularExpression("[a-zA-Z0-9-_|]+")]
        [Column("models")]
        public string Models { get; set; }
    }
}
