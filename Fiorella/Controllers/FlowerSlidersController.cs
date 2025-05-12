using Fiorella.Contexts;
using Fiorella.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiorella.Controllers
{
    [Area("Admin")]
    public class FlowerSlidersController : Controller
    {

        private readonly AppDbContext _context;

        public FlowerSlidersController()
        {
            _context = new AppDbContext();
        }

        [HttpGet]
        public IActionResult Index()
        {

            List<FlowerSlider> flowerSliders = _context.FlowerSliders.ToList();
            return View(flowerSliders);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create(FlowerSlider flowerSlider)
        {
            return View();
        }
    }
}
