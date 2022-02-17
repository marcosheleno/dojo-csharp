using Contact.Domain;
using Email = Contact.Domain.Email;
using Group = Contact.Domain.Group;
using Phone = Contact.Domain.Phone;
using System;
using Moq;
using NUnit.Framework;

namespace classes.tests;

public class ContactTest
{

    [Test]
    public void TestContacts()
    {
        Guid idContact = Guid.NewGuid();
        string name = "Joao das Neves";


        Entity contact = new Entity(idContact, name);

        Assert.AreEqual(idContact, contact.Id);
        Assert.AreEqual(name, contact.Name);
    }

    [Test]
    public void TestContactCanHaveEmails()
    {
        Guid idContact = Guid.NewGuid();
        string name = "Joao das Neves";

        var emailMock = new Moq.Mock<Email.Entity>();
        Email.Entity email = emailMock.Object;

        var collectionMock = new Moq.Mock<Email.Collection>();
        collectionMock.Setup(c => c.Add(email));
        Email.Collection collection = collectionMock.Object;

        Entity contact = new Entity(idContact, name);
        contact.Emails = collection;
        contact.addEmail(email);

        Assert.AreEqual(collection, contact.Emails);
    }

    [Test]
    public void TestContactCanHaveGroups()
    {
        Guid idContact = Guid.NewGuid();
        string name = "Joao das Neves";

        var groupMock = new Moq.Mock<Group.Entity>();
        Group.Entity group = groupMock.Object;

        var collectionMock = new Moq.Mock<Group.Collection>();
        collectionMock.Setup(c => c.Add(group));
        Group.Collection collection = collectionMock.Object;

        Entity contact = new Entity(idContact, name);
        contact.Groups = collection;
        contact.addGroup(group);

        Assert.AreEqual(collection, contact.Groups);
    }

    [Test]
    public void TestContactCanHavePhones()
    {
        Guid idContact = Guid.NewGuid();
        string name = "Joao das Neves";

        var phoneMock = new Moq.Mock<Phone.Entity>();
        Phone.Entity phone = phoneMock.Object;

        var collectionMock = new Moq.Mock<Phone.Collection>();
        collectionMock.Setup(c => c.Add(phone));
        Phone.Collection collection = collectionMock.Object;

        Entity contact = new Entity(idContact, name);
        contact.Phones = collection;
        contact.addPhone(phone);

        Assert.AreEqual(collection, contact.Phones);
    }
}
