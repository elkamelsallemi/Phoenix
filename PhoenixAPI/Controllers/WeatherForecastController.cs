using Microsoft.AspNetCore.Mvc;
using Phoenix.Models;
using Phoenix.Models.Models;

namespace PhoenixAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet("GetTemperature")]
        public IActionResult GetTemperature(int id)
        {
            Temperature temp = new Temperature()
            {
                CountryId = "Tunisia",
                Temp = 25
            };

            return Ok(temp);
        }
    }
}