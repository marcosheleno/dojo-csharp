using System;
using NUnit.Framework;
using Chat.Domain;
using Message = Chat.Domain.Messages;
using Moq;
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

    [Test]
    public void TestContactCanMessages()
    {
        Guid idChat = Guid.NewGuid();

        var emailMock = new Moq.Mock<Message.Entity>();
        Message.Entity email = emailMock.Object;

        var collectionMock = new Moq.Mock<Message.Collection>();
        collectionMock.Setup(c => c.Add(email));
        Message.Collection collection = collectionMock.Object;

        Entity contact = new Entity(idContact, name);
        contact.Emails = collection;
        contact.addEmail(email);

        Assert.AreEqual(collection, contact.Emails);
    }
}
