using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson19Hotel.Models
{
    public class OurRoom
    {
        public int Id { get; set; }
        [StringLength(100)]

        public string Image { get; set; }
        [StringLength(100)]

        public string Title { get; set; }
        [StringLength(500)]

        public string Description { get; set; }
        [StringLength(100)]

        public string Inside1 { get; set; }
        [StringLength(100)]

        public string Inside2 { get; set; }
        [StringLength(50)]

        public string Icon { get; set; }
        [StringLength(100)]

        public string IconWords { get; set; }
    }
}
