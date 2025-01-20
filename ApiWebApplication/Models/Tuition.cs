using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiWebApplication.Models
{
    public class Tuition
    {
        public int Id { get; set; }

        [Required]
        [StringLength (50)]
        [Index(IsUnique =true )]
        public string Code {  get; set; }

        [Required]
        public int WorkingDayId {  get; set; }  
        public WorkingDay WorkingDay { get; set; }

        [Required]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [Required]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [Required]
        public int StatusId { get; set; }
        public Status Status { get; set; }

        [Required]
        public DateTime FirstDate { get; set; }

        [Required]
        public DateTime LastDate { get; set; }

        [Required]
        public  decimal TutionValue {  get; set; }

        [Required]
        public decimal MonthValue { get; set; }

       public List<Strangeness> Strangeness { get; set; }
    }
}