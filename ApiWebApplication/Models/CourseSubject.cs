using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiWebApplication.Models
{
    public class CourseSubject
    {
        public int Id { get; set; }
        [Required (AllowEmptyStrings =false ,ErrorMessage ="El campo curso no puede ser vacio")]
        public int CourseId {  get; set; }
       public Course Course { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo asignatura no puede ser vacio")]
        public int SchoolSubjectId {  get; set; }   
        public SchoolSubject SchoolSubject { get; set; }    

    }
}