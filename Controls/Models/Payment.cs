using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Controls.Models
{
    public class Payment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]        
        public string Code { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public decimal Value { get; set; }

        [Required]
        public bool IsTotalPay { get; set; }

        [Column(TypeName = "varchar")]
        public string Remark { get; set; }

        [Required]
        public int MonthlyPaymentId {  get; set; }
        public MonthlyPayment MonthlyPayment {  get; set; }
       public   List <PaymentDetail> PaymentDetails { get; set; }

    }
}