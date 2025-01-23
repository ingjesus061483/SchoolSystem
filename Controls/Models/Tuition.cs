using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Controls.Models
{
    public class Tuition
    {
        public int Id { get; set; }

        [Required]
        [StringLength (50)]
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
        public DateTime FirstDate { get; set; }

        [Required]
        public DateTime LastDate { get; set; }

        [Required]
        public  decimal TutionValue {  get; set; }

        [Required]
        public decimal MonthValue { get; set; }

        [Required]
        public int StatusId { get; set; }
        public Status Status { get; set; }

        public List <Strangeness> Strangenesses { get; set; }

        public double Duration
        {
            get
            {
                return (LastDate - FirstDate).Days / 30;
            }
        }
    }
}