using Lesson19Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson19Hotel.ViewModels
{
    public class HomeModel
    {
        public IEnumerable<Slider> Sliders { get; set; }

        public IEnumerable<AFewWords> AFewWordss { get; set; }

        public IEnumerable<OurRoom> OurRooms { get; set; }

        public IEnumerable<Restaurant> Restaurants { get; set; }

        public IEnumerable<Count> Counts { get; set; }

        public IEnumerable<OurNews> OurNewss { get; set; }
    }
}
