using Messages = Chat.Domain.Messages;
using Contacts = Chat.Domain.Contacts;
namespace Chat.Domain;


class Chat : BaseClass
{
    public Contacts.Entity Contact {get; set;}
    private Messages.Collection _messages;


    public Chat(Guid id) 
    {
        Id = id;
    }

    public Messages.Collection Messages
    {
        set { _messages = value; }
        get { return _messages; }
    }

    public void addMessages(Messages.Entity message)
    {
        Messages.Add(message);
    }
}

