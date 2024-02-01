using Location.Data;
using Location.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Location.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private LocationContext context { get; set; }
        public LocationController(LocationContext ctx) => context = ctx;
        [HttpGet]
        public async Task<IEnumerable<LocationModel>> Get() => await context.locations.ToListAsync();

    }
}

