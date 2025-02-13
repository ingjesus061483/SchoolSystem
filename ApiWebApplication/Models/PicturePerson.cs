using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiWebApplication.Models
{
    public class PicturePerson
    {
        public int Id { get; set; }

        public int PictureId {  get; set; }
        public Picture  Picture { get; set; }
       
        public int? TeacherId { get; set; }
        public Teacher Teacher{ get; set; }

        public int? StudentId {  get; set; }
        public Student Student { get; set; }
    }
}