using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ApiWebApplication.Models;

namespace ApiWebApplication.DTO
{
    public class CourseDTO
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="El campo codigo no puede ser vacio",AllowEmptyStrings =false)]
        [Column(TypeName = "varchar")]
        [MaxLength(50,ErrorMessage ="El tamaño no puede ser mayor de 50" )]
        [Index(IsUnique = true)]        
        public string Code {  get; set; }

        [Required(ErrorMessage = "El campo nombre no puede ser vacio", AllowEmptyStrings = false)]
        [Column(TypeName = "varchar")]
        [MaxLength(50, ErrorMessage = "El tamaño no puede ser mayor de 50")] 
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        public string Description { get; set; }

        [Required (ErrorMessage ="El campo capacidad no puede ser vacio")]        
        [Column(TypeName = "decimal")]        
        public decimal Amount { get; set; }

    public List <Achievement >    Achievements { get; set; }
        public List<CourseSubjectDTO> CourseSubjects { get; set; }
        public List<Tuition> Tuitions { get; set; }

    }
}