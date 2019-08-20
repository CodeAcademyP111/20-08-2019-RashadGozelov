using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson19Hotel.DAL;
using Lesson19Hotel.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace Lesson19Hotel.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeModel homemodel = new HomeModel
            {
                Sliders = _context.Sliders,
                AFewWordss=_context.AFewWordss,
                OurRooms=_context.OurRooms,
                Restaurants=_context.Restaurants,
                Counts=_context.Counts,
                OurNewss=_context.OurNewss
            };
            return View(homemodel);
        }
    }
}