using Microsoft.AspNetCore.Mvc;

namespace eConstruction.Service.Order.Controllers
{
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Order-Freezing",
            "Order-Bracing",
            "Order-Chilly",
            "Order-Cool",
            "Order-Mild",
            "Order-Warm",
            "Order-Balmy",
            "Order-Hot",
            "Order-Sweltering",
            "Order-Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetOrderWeatherForecast")]
        public IEnumerable<WeatherForecast> GetOrderWeatherForecast()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
