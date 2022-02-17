using System;
using NUnit.Framework;
using Message = Chat.Domain.Messages;
using Contact = Chat.Domain.Contacts;
using Chat.Domain;
using Moq;
namespace classes.tests;

public class ChatTest
{

    [Test]
    public void TestChat()
    {
        Guid idChat = Guid.NewGuid();

        var contactMock = new Moq.Mock<Contact.Entity>();
        Contact.Entity contact = contactMock.Object;

        Entity chat = new Entity(idChat, contact);

        Assert.AreEqual(idChat, chat.Id);
        Assert.AreEqual(contact, chat.Contact);
    }

    [Test]
    public void TestChatCanMessages()
    {
        Guid idChat = Guid.NewGuid();

        var contactMock = new Moq.Mock<Contact.Entity>();
        Contact.Entity contact = contactMock.Object;

        var collectionMock = new Moq.Mock<Message.Collection>();
        collectionMock.Setup(c => c.Add(It.IsAny<Message.Entity>()));
        Message.Collection collection = collectionMock.Object;

        Entity chat = new Entity(idChat, contact);
        chat.Messages = collection;
        chat.sendMessages("mensagem teste");

        Assert.AreEqual(collection, chat.Messages);
    }
}
