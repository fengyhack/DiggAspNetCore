using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaiAdmin.Models
{
    [Table("FileMetaInfo")]
    public partial class FileMetaInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [RegularExpression("[a-zA-Z0-9-_]+")]
        [Column("key")]
        public string Key { get; set; }

        [Required]
        [Column("filename")]
        public string FileName { get; set; }

        [Required]
        [Column("zipped")]
        public bool? IsZipped { get; set; }

        [Required]
        [Column("location")]
        public string Location { get; set; }
    }
}
