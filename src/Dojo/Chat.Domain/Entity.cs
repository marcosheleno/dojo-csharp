using System;
using Messages = Chat.Domain.Messages;
using Contacts = Chat.Domain.Contacts;
namespace Chat.Domain;

class Chat : BaseClass
{
    public Contacts.Entity Contact {get; set;}
    public Messages.Collection Messages {get; set;}


    public Chat(Guid id) 
    {
        Id = id;
    }

    public void sendMessages(string message)
    {   
        Guid idMessage = Guid.NewGuid();
        DateTime data_time = DateTime.Now;
        Messages.Entity chatMessage = new Messages.Entity(idMessage, date_time, message);

        Messages.Add(message);
    }
}
