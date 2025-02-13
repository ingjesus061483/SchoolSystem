using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using ApiWebApplication.DTO;

namespace ApiWebApplication.Models
{ 
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Index(IsUnique = true)]
        public string Identification { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

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
        public int SexId { get; set; }
        public Sex Sex { get; set; }


        [Required]
        public int IdentificationTypeId { get; set; }
        public IdentificationType IdentificationType { get; set; }

        public List<CourseSubject> CourseSubjects { get; set; }

        public List<PicturePerson> picturePeople { get; set; }


        
    }
}