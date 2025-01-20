using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserControls.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="El campo codigo no puede ser vacio",AllowEmptyStrings =false)]
        [MaxLength(50,ErrorMessage ="El tamaño no puede ser mayor de 50" )]
        [Column(TypeName = "varchar")]
        public string Code {  get; set; }

        [Required(ErrorMessage = "El campo nombre no puede ser vacio", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "El tamaño no puede ser mayor de 50")]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required (ErrorMessage ="El campo capacidad no puede ser vacio")]        
        [Column(TypeName = "decimal")]        
        public decimal Amount { get; set; }
        public List<Tuition> Tuitions { get; set; }

        public List <CourseSubject  > CourseSubjects    { get; set; }
        public string Reference 
        {
            get
            {
                return Code + " - " + Name; 
            }
                
        }
    }
}