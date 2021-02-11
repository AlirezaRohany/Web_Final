using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_final.Models;
using web_final.Models.Patient;

namespace web_final.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("hello-amo")]
        public IActionResult SayHello()
        {
            return Ok("hello");
        }

        [HttpPost("patient-login")]
        public IActionResult SendPatienLogin(PatientRegisterRequest loginRequest)
        { 
            System.Console.WriteLine(loginRequest);
            return Ok("got you login");
        }
    }
}
