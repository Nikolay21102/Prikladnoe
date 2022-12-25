using Microsoft.AspNetCore.Mvc;
using ShopApi.Contracts;

namespace ShopApi.Web.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILoggerManager _logger;


    public WeatherForecastController(ILoggerManager logger)
    {
        _logger = logger;
    }
    
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.LogInfo("Вот информационное сообщение от нашего контроллера значений.");
        _logger.LogDebug("Вот отладочное сообщение от нашего контроллера значений.");
        _logger.LogWarn("Вот сообщение предупреждения от нашего контроллера значений.");
        _logger.LogError("Вот сообщение об ошибке от нашего контроллера значений.");
        
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }
}