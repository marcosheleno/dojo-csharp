using Contact.Domain;
using Email = Contact.Domain.Email;
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
}
