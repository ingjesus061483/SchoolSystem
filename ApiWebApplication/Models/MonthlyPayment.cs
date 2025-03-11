using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiWebApplication.Models
{
    public class MonthlyPayment
    {
       public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Index(IsUnique = true)]
        public string Code { get; set; }

        [Column(TypeName = "varchar")]
        public string Detail { get; set; }


        [Required]      
        public DateTime Since { get; set; }

        [Required]
        public DateTime Untill { get; set; }

        [Required]
        public decimal Value { get; set; }

        public bool IsConfirmed { get; set; }

        public int TuitionId { get; set; } 
        public Tuition  Tuition { get; set; }
      public List<Payment> Payments { get; set; }
        
    }
}