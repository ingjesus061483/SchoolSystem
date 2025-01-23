using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Controls   .Models
{
    public class CourseSubject
    {
        public int Id { get; set; }
        [Required]
        public int CourseId {  get; set; }
       public Course Course { get; set; }

        [Required]
        public int SchoolSubjectId {  get; set; }   
        public SchoolSubject SchoolSubject { get; set; }    

    }
}