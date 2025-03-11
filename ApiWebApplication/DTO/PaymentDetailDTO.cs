using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ApiWebApplication.Models;

namespace ApiWebApplication.DTO
{
    public class PaymentDetailDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
       public decimal Value { get; set; }

        [Required]
        public int PaymentId {  get; set; }

        [Required]
        public Payment Payment { get; set; }

        [Required]
        public int MethodOfPaymentId {  get; set; }
        public MethodOfPayment MethodOfPayment {  get; set; }
    }
}