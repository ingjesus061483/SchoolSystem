﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Controls.Models
{
    public class PicturePerson
    {
        public int Id { get; set; }

        public int PictureId {  get; set; }
        public Picture  Picture { get; set; }

        public int? StudentId {  get; set; }
      
        public int? TeacherId { get; set; }

        public string Student { get; set; }

        public string Teacher { get; set; }
    }
}