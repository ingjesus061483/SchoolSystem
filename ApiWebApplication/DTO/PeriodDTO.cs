using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ApiWebApplication.Models;

namespace ApiWebApplication.DTO
{
    public class PeriodDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Titulo no puede ser vacio", AllowEmptyStrings = false)]
        [Column(TypeName = "varchar")]
        [MaxLength(50, ErrorMessage = "El tamaño no puede ser mayor de 50")]
        public string Title { get; set; }

        public DateTime ? Since { get; set; }

        public DateTime? Untill { get; set; }

        public string Description { get; set; }

        public List<Achievement> Achievements { get; set; }

    }
}