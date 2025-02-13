using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Controls.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
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
        
        public  List<PicturePerson> PicturePeople { get ; set; }
        public List<CourseSubject> CourseSubjects { get; set; }


        public double  Age
        {
            get
            {
                return  Math .Round ( (DateTime.Now-BirthDate  ).TotalDays / 365);
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