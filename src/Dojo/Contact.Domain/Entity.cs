using System;
using System.Collections.ObjectModel;
using Email = Contact.Domain.Email;

namespace Contact.Domain;

public class Entity : BaseClass
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private Email.Collection _emails;

    public Email.Collection Emails
    {
        set { _emails = value; }
        get { return _emails; }
    }

    public Entity(Guid id, string name)
    {
        this.Id = id;
        this.Name = name;
    }

    public void addEmail(Email.Entity email)
    {
        this.Emails.Add(email);
    }
}
