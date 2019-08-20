using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson19Hotel.Models
{
    public class OurNews
    {
        public int Id { get; set; }
        [Required,StringLength(100)]

        public string Title { get; set; }
        [Required,StringLength(100)]

        public string Image { get; set; }
        [Required, StringLength(100)]

        public string ImageModal { get; set; }
        [Required, StringLength(100)]

        public string TitlePicture { get; set; }
        [Required, StringLength(400)]

        public string Description1 { get; set; }
        [Required, StringLength(400)]

        public string Description2 { get; set; }
        [StringLength(50)]

        public string Activ { get; set; }
    }
}
