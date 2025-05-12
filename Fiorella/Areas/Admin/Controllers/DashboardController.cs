using Fiorella.Contexts;
using Fiorella.Models;
using Microsoft.AspNetCore.Mvc;
namespace Fiorella.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;
        /*
                public DashboardController(AppDbContext context)
                {
                    _context= context;
                }*/

        public DashboardController()
        {
            _context = new AppDbContext();

        }
        public IActionResult Index()
        {

            List<FlowerSlider> flowerSliders = _context.FlowerSliders.ToList();
            return View(flowerSliders);
        }
    }
}
