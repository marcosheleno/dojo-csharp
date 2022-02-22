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
        List<ContactDomain.Entity> list = new List<ContactDomain.Entity>();

        var readServiceMock = new Moq.Mock<ContactDomain.Contracts.IReadServices>();
        readServiceMock.Setup(c => c.getAll()).Returns(list);

        Controller.WeatherForecastController contactController = new Controller.WeatherForecastController(readServiceMock.Object);
        
        Assert.AreEqual(contactController.Get(), list);
    }

    [Test]
    public void ControllerTestCanHaveContactData()
    {
        List<ContactDomain.Entity> list = new List<ContactDomain.Entity>();
        list.Add(new ContactDomain.Entity(Guid.NewGuid(), "João das Neves"));

        var readServiceMock = new Moq.Mock<ContactDomain.Contracts.IReadServices>();
        readServiceMock.Setup(c => c.getAll()).Returns(list);
        
        Controller.WeatherForecastController contactController = new Controller.WeatherForecastController(readServiceMock.Object);
        
        Assert.AreEqual(contactController.Get(), list);
    }
}
