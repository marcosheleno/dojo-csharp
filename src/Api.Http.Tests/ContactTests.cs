using Contact.Domain;
using NUnit.Framework;
using Infra = Infrastructure.Persistance.Archive;
using ContactInfra = Contact.Infrastructure;
using ContactDomain = Contact.Domain;
using Controller = application.Controllers;


namespace Api.Http.Tests;
[TestFixture]
public class ContactTests
{
    [Test]
    public void ControllerTestCanHaveEmptyList()
    {
        var a = JsonConvert.DeserializeObject(@"[]").ToString();
        dynamic dynObj = JsonConvert.DeserializeObject(a);

        var jsonReaderMock = new Moq.Mock<Archive.JsonReader>();
        jsonReaderMock.Setup(c => c.read(It.IsAny<string>())).Returns(dynObj);

        var contactRepositoryMock = new Moq.Mock<ContactInfra.Repository>(jsonReader.Object);
        ContactInfra.Repository contactRepository = contactRepositoryMock.Object;

        var readServiceMock = new Moq.Mock<ContactDomain.ReadService>(contactRepository);
        readServiceMock.Setup(c => c.getAll()).Returns(0);
        ContactDomain.ReadService readService = readServiceMock.Object;

        Controller.WeatherForecastController contactController = new Controller.WeatherForecastController(readService);
        
        Assert.IsEmpty(contactController.Get());
    }

}
