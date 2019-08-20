using Lesson19Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson19Hotel.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<AFewWords> AFewWordss { get; set; }
        public DbSet<OurRoom> OurRooms { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Count> Counts { get; set; }
        public DbSet<OurNews> OurNewss { get; set; }
    }
}
