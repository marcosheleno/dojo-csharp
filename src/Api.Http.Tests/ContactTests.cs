using System;
using System.Collections.Generic;
using Contact.Domain;
using NUnit.Framework;
using Moq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        var jsonReaderMock = new Moq.Mock<Infra.JsonReader>();
        jsonReaderMock.Setup(c => c.read(It.IsAny<string>())).Returns(dynObj);

        var contactRepositoryMock = new Moq.Mock<ContactInfra.Repository>(jsonReaderMock.Object);
        ContactInfra.Repository contactRepository = contactRepositoryMock.Object;

        var readServiceMock = new Moq.Mock<ContactDomain.ReadService>(contactRepository);
        readServiceMock.Setup(c => c.getAll()).Returns(new List<ContactDomain.Entity>());
        ContactDomain.ReadService readService = readServiceMock.Object;

        Controller.WeatherForecastController contactController = new Controller.WeatherForecastController(readService);
        
        Assert.IsEmpty(contactController.Get());
    }

    [Test]
    public void ControllerTestCanHaveContactData()
    {
        List<ContactDomain.Entity> list = new List<ContactDomain.Entity>();
        list.Add(new ContactDomain.Entity(Guid.NewGuid(), "João das Neves"));
        var contactRepositoryMock = new Moq.Mock<ContactDomain.Contracts.IRepository>();

        var readServiceMock = new Moq.Mock<ContactDomain.ReadService>(contactRepositoryMock.Object);
        readServiceMock.Setup(c => c.getAll()).Returns(list);
        
        Controller.WeatherForecastController contactController = new Controller.WeatherForecastController(readServiceMock.Object);
        
        Assert.AreEqual(contactController.Get(), list);
    }

}
