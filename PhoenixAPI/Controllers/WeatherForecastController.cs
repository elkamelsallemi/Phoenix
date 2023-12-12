using Microsoft.AspNetCore.Mvc;
using Phoenix.Models.Models;

namespace PhoenixAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet("GetTemerature")]
        public IActionResult Get(int id)
        {
            Temperature temp = new Temperature();

            if (id == 0)
            {
                temp.CountryId = "0";
                temp.Temp = 25;
                return Ok(temp);
            }

            return NotFound("Country with this Id not Exist in database");
            
        }
    }
}