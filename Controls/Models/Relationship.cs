using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Controls .Models
{
    public class Relationship
    {
        public int Id { get; set; }

        [Required ]
        [StringLength (50)]
        public string Name { get; set; }

        public string Description { get; set; }
        
      public   List<Attendant> Attendants { get; set; }
    }
}