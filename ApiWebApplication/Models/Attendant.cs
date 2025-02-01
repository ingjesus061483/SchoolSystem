using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiWebApplication.Models
{
    public class Attendant
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Index(IsUnique = true)]
        public string Identification { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }
        

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string PhoneNumber { get; set; }


        [Required]
        [EmailAddress]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Email { get; set; }
        
        [Required]
        public int  RelationshipId { get; set; }
        public   Relationship Relationship { get; set; }

      public  List<Student> Students { get; set; }


    }
}