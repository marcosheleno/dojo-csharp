using System;
using NUnit.Framework;
using Message = Chat.Domain.Messages;
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

        var messageMock = new Moq.Mock<Message.Entity>();
        Message.Entity message = messageMock.Object;

        var collectionMock = new Moq.Mock<Message.Collection>();
        collectionMock.Setup(c => c.Add(message));
        Message.Collection collection = collectionMock.Object;

        Entity chat = new Entity(idChat);
        chat.Messages = collection;
        chat.sendMessages(message);

        Assert.AreEqual(collection, chat.Messages);
    }
}
