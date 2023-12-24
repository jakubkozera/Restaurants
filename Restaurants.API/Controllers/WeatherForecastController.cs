using Microsoft.AspNetCore.Mvc;

namespace Restaurants.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherForecastService _weatherForecastService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, 
        IWeatherForecastService weatherForecastService)
    {
        _logger = logger;
        _weatherForecastService = weatherForecastService;
    }

    [HttpGet]
    [Route("example")]
    public IEnumerable<WeatherForecast> Get()
    {
        var result = _weatherForecastService.Get();
        return result;
    }

    [HttpGet]
    [Route("{take}/currentDay")]
    public WeatherForecast Get([FromQuery]int max, [FromRoute]int take)
    {
        var result = _weatherForecastService.Get().First();
        return result;
    }

    [HttpPost]
    public string Hello([FromBody] string name)
    {
        return $"Hello {name}";
    }
}
