using Microsoft.AspNetCore.Mvc;
using ContactDomain = Contact.Domain;

namespace application.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    private readonly ContactDomain.Contracts.IReadServices _readService;

    public WeatherForecastController(ContactDomain.Contracts.IReadServices readService)
    {
        _readService = readService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public List<ContactDomain.Entity> Get()
    {
        return _readService.getAll();
    }
}
