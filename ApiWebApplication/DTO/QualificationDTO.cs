using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ApiWebApplication.Models;

namespace ApiWebApplication.DTO
{
    public class QualificationDTO
    {
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Index(IsUnique = true)]
        public string Code { get; set; }

        [Required]
        DateTime DateTime { get; set; }

          
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Title { get; set; }    

        [Required]
        public decimal Note {  get; set; }
        
        [Required]
        public string Detail { get; set; }

        [Required]
        public int StudentId {  get; set; }
        public Student Student { get; set; }

        [Required]
        public int AchievementID { get; set; }
        public Achievement Achievement { get; set; }
        
    }
}