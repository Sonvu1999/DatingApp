using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DatingApp.API.Controllers
{

    [ApiController]
    // https://localhost:5000/api/weatherforecast

    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly Properties.Data.DataContext _context;
        public WeatherForecastController(Properties.Data.DataContext context)
        {
            _context = context;
        }
        // throw new Exception("Test Exception");
        
      [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> getValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> getValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }
        [HttpPost]
        public void Post ([FromBodi] string value){}

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    internal class FromBodiAttribute : Attribute
    {
    }
}
