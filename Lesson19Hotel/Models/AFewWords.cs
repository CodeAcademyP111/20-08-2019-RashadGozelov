using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson19Hotel.Models
{
    public class AFewWords
    {
        public int Id { get; set; }
        [Required,StringLength(100)]

        public string Icon { get; set; }
        [Required, StringLength(100)]

        public string TitleBig { get; set; }
        [Required, StringLength(100)]

        public string TitleSmall { get; set; }
        [Required, StringLength(400)]

        public string Description { get; set; }
    }
}
