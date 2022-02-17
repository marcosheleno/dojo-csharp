using System;
using System.Collections.ObjectModel;
using Email = Contact.Domain.Email;
using Group = Contact.Domain.Group;

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
    private Group.Collection _groups;


    public Email.Collection Emails
    {
        set { _emails = value; }
        get { return _emails; }
    }

     public Group.Collection Groups
    {
        set { _groups = value; }
        get { return _groups; }
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

    public void addGroup(Group.Entity group)
    {
        this.Groups.Add(group);
    }
}
