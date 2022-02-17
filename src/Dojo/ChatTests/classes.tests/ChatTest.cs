using System;
using NUnit.Framework;
// using Message = Chat.Domain.Messages;
namespace classes.tests;

public class ChatTest
{

    [Test]
    public void TestChat()
    {
        Guid idChat = Guid.NewGuid();

        Entity chat = new Entity(idChat);

        Assert.AreEqual(idChat, chat.Id);
    }

    /*[Test]
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
    }*/
}
