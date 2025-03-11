using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Controls.Models
{
    public class MonthlyPayment
    {
       public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]        
        public string Code { get; set; }

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
        public string Detail { get; set; }

        public string Monthly
        {
            get
            {
                return Since.ToString("MMMM") + " - " + Untill.ToString("MMMM");
            }
        }
        public string Confirmed
        {
            get
            {
                return IsConfirmed ? "Si" : "No";
            }
        }
    }
}