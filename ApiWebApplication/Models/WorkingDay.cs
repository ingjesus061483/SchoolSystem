﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWebApplication.Models
{
    public class WorkingDay
    {
        public int Id { get; set; }

        [Required]
        [StringLength (50)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Tuition> tuitions { get; set; }
    }
}
