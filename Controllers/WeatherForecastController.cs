using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private DataContext _context;

        public WeatherForecastController(DataContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult> GetSehirler()
        {
            var sehirler = _context.Sehirler.ToList();
            return Ok(sehirler);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetSehir(int id)
        {
            var sehirler = _context.Sehirler.FirstOrDefault(x => x.Id == id);
            return Ok(sehirler);
        }
    }
}
