using System;
using System.Collections.Generic;
using NUnit.Framework;
using Moq;
using ContactDomain = Contact.Domain;

namespace classes.tests;

[TestFixture]
public class ReadServiceTest
{
    [Test]
    public void TestIfReadServiceCanRetrieveEmptyList(){
        var repositoryMock = new Moq.Mock<ContactDomain.Contracts.IRepository>();
        repositoryMock.Setup(c => c.getAll()).Returns(new List<ContactDomain.Entity>());

        ContactDomain.ReadService readService = new ContactDomain.ReadService(repositoryMock.Object);

        Assert.IsEmpty(readService.getAll());
    }

    [Test]
    public void TestIfReadServiceCanRetrieveANonEmptyList(){
        List<ContactDomain.Entity> list = new List<ContactDomain.Entity>();
        list.Add(new ContactDomain.Entity(Guid.NewGuid(), "Joao das Neves"));

        var repositoryMock = new Moq.Mock<ContactDomain.Contracts.IRepository>();
        repositoryMock.Setup(c => c.getAll()).Returns(list);

        ContactDomain.ReadService readService = new ContactDomain.ReadService(repositoryMock.Object);

        Assert.IsNotEmpty(readService.getAll());
    }
}
