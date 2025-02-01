using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Controls.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Identification {  get; set; }


        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }


        [Required]        
        public DateTime  BirthDate { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Address {  get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string PhoneNumber {  get; set; }


        [Required]
        [EmailAddress]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Email {  get; set; }

        [Required]        
        public int SexId {  get; set; }
        public Sex Sex { get; set; }

        [Required]
        public int IdentificationTypeId {  get; set; }        
        public IdentificationType IdentificationType { get; set; }     

        public List<PicturePerson> picturePeople { get; set; }

        public List<Tuition> Tuitions { get; set; }
      public int? AttendantId {  get; set; }
        public Attendant Attendant { get; set; }
        public double Age
        {
            get
            {
                return Math.Round((DateTime.Now - BirthDate).TotalDays / 365);
            }
        }
        public string CompleteName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}