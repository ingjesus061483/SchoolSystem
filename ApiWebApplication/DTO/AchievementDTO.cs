using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ApiWebApplication.Models;

namespace ApiWebApplication.DTO
{
    public class AchievementDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Index(IsUnique = true)]
        public string Code{ get; set;}

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        public string Description { get; set; }

        [Required ]
        public int SchoolSubjectId { get; set; }
        public SchoolSubject SchoolSubject { get; set; }

        [Required]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [Required]
        public int PeriodId { get; set; }
        public Period Period { get; set; }
    }
}