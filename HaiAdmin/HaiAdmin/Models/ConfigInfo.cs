﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaiAdmin.Models
{
    [Table("ConfigInfo")]
    public partial class ConfigInfo
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
        [RegularExpression("[a-zA-Z0-9-_]+")]
        [Column("model")]
        public string Model { get; set; }

        [Required]
        [RegularExpression("[a-zA-Z0-9-_]+")]
        [Column("key")]
        public string Key { get; set; }
    }
}
