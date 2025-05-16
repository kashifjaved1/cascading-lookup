using CascadingLookup.Data;
using Microsoft.AspNetCore.Mvc;

namespace CascadingLookup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupApiController : ControllerBase
    {
        private readonly AppDbContext _context;
        public LookupApiController(AppDbContext context) => _context = context;

        [HttpGet("cities/{countryId}")]
        public IActionResult GetCities(int countryId)
        {
            var cities = _context.Cities.Where(c => c.CountryId == countryId).ToList();
            return Ok(cities);
        }

        [HttpGet("areas/{cityId}")]
        public IActionResult GetAreas(int cityId)
        {
            var areas = _context.Areas.Where(a => a.CityId == cityId).ToList();
            return Ok(areas);
        }
    }
}
