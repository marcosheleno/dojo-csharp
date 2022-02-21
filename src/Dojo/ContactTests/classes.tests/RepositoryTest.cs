using Contact.Infrastructure;
using System;
using Moq;
using NUnit.Framework;
using Infrastructure.Persistance.Archive;
using Newtonsoft.Json.Linq;

namespace classes.tests;

public class RepositoryTest
{
    [Test]
    public void TestRepositoryCanHaveEmptyList()
    {
        var jObjectMock = new Moq.Mock<JObject>();
        jObjectMock.Setup(c => c.length()).Returns(0);

        var jsonMock = new Moq.Mock<JsonReader>();
        jsonMock.Setup(c => c.read(It.IsAny<string>())).Returns(jObjectMock);

        Repository repo = new Repository(jsonMock.Object);

        Assert.IsEmpty(repo.getAll());
    }

    [Test]
    public void TestRepositoryCanHasContact()
    {
        Guid idContact = Guid.NewGuid();
        string name = "Joao das Neves";
        Entity contact = new Entity(idContact, name);

        JObject jObjectMock = new JObject
        {
            { "id", 10 },
            { "name", "João das Neves" }
        };

       var jsonMock = new Moq.Mock<JsonReader>();
        jsonMock.Setup(c => c.read(It.IsAny<string>())).Returns(jObjectMock);

        Repository repo = new Repository(jsonMock.Object);

        Assert.AreEqual(repo.getAll());
    }
}
