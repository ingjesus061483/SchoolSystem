using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiWebApplication.Models
{
    public class Strangeness
    {
        public int Id { get; set; }

        [Required]
        public int TuitionId { get; set; }
        public Tuition Tuition { get; set; }

        [Required]
        public int ConceptId { get; set; }
        public Concept Concept { get; set; }

        public string Description {  get; set; }

    }
}