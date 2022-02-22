using Contact.Domain;
using NUnit.Framework;
using Infra = Infrastructure.Persistance.Archive;
using ContactInfra = Contact.Infrastructure;
using ContactDomain = Contact.Domain;
using Controller = application.Controllers;


namespace Api.Http.Tests;

public class ContactTests
{
    [SetUp]
    public void ControllerTestCanHaveEmptyList()
    {
        var jsonReaderMock = new Moq.Mock<Infra.JsonReader>();
        Infra.JsonReader jsonReader = jsonReaderMock.Object;

        var contactRepositoryMock = new Moq.Mock<ContactInfra.Repository>(jsonReader);
        ContactInfra.Repository contactRepository = contactRepositoryMock.Object;

        var readServiceMock = new Moq.Mock<ContactDomain.ReadService>(contactRepository);
        readServiceMock.Setup(c => c.getAll()).Returns(0);
        ContactDomain.ReadService readService = readServiceMock.Object;

        Controller.WeatherForecastController contactController = new Controller.WeatherForecastController(readService);
        
        Assert.IsEmpty(contactController.Get());
    }

}
