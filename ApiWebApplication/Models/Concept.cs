using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiWebApplication.Models
{
    public class Concept
    {
        public int Id {  get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength (50)]
        [Column(TypeName = "varchar")]
        public string Code { get; set; }
        [Required ]
        [StringLength(50)]
        [Column(TypeName ="varchar")]
        public string Title { get; set; }

        [Column(TypeName = "varchar")]
        public string Description { get; set; }
    }
}