using ApiWebApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace ApiWebApplication.DTO
{
    public class PicturePersonDTO
    {
        public int Id { get; set; }

        [Required] 
        public int PictureId {  get; set; }
        public Picture  Picture { get; set; }

        [Required]
        public int StudentId {  get; set; }

        [Required]
        public string Student {  get; set; }
       // public Student Student { get; set; }
    }
}