using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson19Hotel.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required,StringLength(100)]

        public string Title1 { get; set; }
        [Required, StringLength(100)]

        public string Title2 { get; set; }
        [Required, StringLength(100)]

        public string Image { get; set; }
        [StringLength(50)]

        public string Activ { get; set; }
    }
}
