﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiWebApplication.Models
{
    public class Status
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        public string Description { get; set; }

        public List<Tuition > Tuitions  { get; set; }
    }
}