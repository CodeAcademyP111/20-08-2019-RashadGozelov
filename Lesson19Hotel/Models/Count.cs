using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson19Hotel.Models
{
    public class Count
    {
        public int Id { get; set; }
        [Required]

        public int CountFrom { get; set; }
        [Required]

        public int CountTo { get; set; }
        [Required,StringLength(100)]

        public string Title { get; set; }
    }
}
