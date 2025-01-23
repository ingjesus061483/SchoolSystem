using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controls.Models
{
    public class Picture
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Title { get; set; }


        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Type { get; set; }

        [Required]
        public byte[] Data { get; set; }

        public List<PicturePerson> picturePeople { get; set; }
    }
}
