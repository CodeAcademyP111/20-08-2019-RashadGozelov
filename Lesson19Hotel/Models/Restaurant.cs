using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson19Hotel.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required,StringLength(100)]

        public string Title { get; set; }
        [Required, StringLength(800)]

        public string Description { get; set; }
        [Required, StringLength(50)]

        public string Image { get; set; }
    }
}
