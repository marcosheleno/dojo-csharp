using Microsoft.AspNetCore.Mvc;
using Infra = Infrastructure.Persistance.Archive;
using ContactInfra = Contact.Infrastructure;
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

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public List<ContactDomain.Entity> Get()
    {
        Infra.JsonReader jsonReader = new Infra.JsonReader();
        ContactInfra.Repository contactRepository = new ContactInfra.Repository(jsonReader);
        ContactDomain.ReadService readService = new ContactDomain.ReadService(contactRepository);

        return readService.getAll();
        
    }
}
