using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Controls.Models
{
    public class Strangeness
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Code { get; set; }


        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int TuitionId { get; set; }
        //    public Tuition Tuition { get; set; }

        public string Course { get; set; }


        [Required]
        public int ConceptId { get; set; }
        public Concept Concept { get; set; }

        public string Detail {  get; set; }

    }
}