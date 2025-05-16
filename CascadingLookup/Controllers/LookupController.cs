using CascadingLookup.Data;
using Microsoft.AspNetCore.Mvc;

namespace CascadingLookup.Controllers
{
    public class LookupController : Controller
    {
        private readonly AppDbContext _context;
        public LookupController(AppDbContext context) => _context = context;

        public IActionResult Index()
        {
            var countries = _context.Countries.ToList();
            return View(countries);
        }
    }
}
