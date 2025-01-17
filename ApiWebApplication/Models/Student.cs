using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiWebApplication.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Index(IsUnique = true)]
        public string Identification {  get; set; }


        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }


        [Required]        
        public DateTime  BirthDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Address {  get; set; }

        [Required]
        [StringLength(50)]
        public string PhoneNumber {  get; set; }


        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Email {  get; set; }

        [Required]        
        public int SexId {  get; set; }
        public Sex Sex { get; set; }

        [Required]
        public int IdentificationTypeId {  get; set; }        
        public IdentificationType IdentificationType { get; set; }
    }
}