using Microsoft.AspNetCore.Mvc;
using MyAppBackend.Models;
using System.Collections.Generic;

namespace MyAppBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<WeatherForecast> GetWeather()
        {
            return new List<WeatherForecast>
            {
                new WeatherForecast { Date = "2024-11-08", TemperatureC = 10, Summary = "Cold" },
                new WeatherForecast { Date = "2024-11-09", TemperatureC = 15, Summary = "Chilly" }
            };
        }
    }
}
