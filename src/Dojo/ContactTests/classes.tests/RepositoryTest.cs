using Contact.Infrastructure;
using System;
using Moq;
using NUnit.Framework;
using Infrastructure.Persistance.Archive;

namespace classes.tests;

public class RepositoryTest
{
    [Test]
    public void TestRepositoryCanHaveEmptyList()
    {
        var jsonMock = new Moq.Mock<JsonReader>();
        jsonMock.Setup(c => c.read(It.IsAny<string>()));
        Repository repo = new Repository(jsonMock.Object);

        Assert.IsEmpty(repo.getAll());
    }

    [Test]
    public void TestRepositoryCanHaveOneElement()
    {
        var jsonMock = new Moq.Mock<JsonReader>();
        jsonMock.Setup(c => c.read(It.IsAny<string>()));
        Repository repo = new Repository(jsonMock.Object);

        Assert.IsEmpty(repo.getAll());
    }
}
