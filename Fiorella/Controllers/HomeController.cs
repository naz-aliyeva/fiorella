using Fiorella.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Fiorella.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    /*  public HomeController(AppDbContext context)
      {
        _context = context;
      }*/


    public HomeController()
    {
        _context = new AppDbContext();
    }
    public IActionResult Index()
    {

        return View();
    }
}
