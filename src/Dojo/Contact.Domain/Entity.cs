using System;
using System.Collections.ObjectModel;
using Email = Contact.Domain.Email;
using Group = Contact.Domain.Group;
using Phone = Contact.Domain.Phone;

namespace Contact.Domain;

public class Entity : BaseClass
{
    public string Name {get; set;}

    private Email.Collection _emails;

    private Group.Collection _groups;

    private Phone.Collection _phones;

    public Entity(Guid id, string name)
    {
        this.Id = id;
        this.Name = name;
    }

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

    public Phone.Collection Phones
    {
        set { _phones = value; }
        get { return _phones; }
    }

    public void addEmail(Email.Entity email)
    {
        this.Emails.Add(email);
    }

    public void addGroup(Group.Entity group)
    {
        this.Groups.Add(group);
    }

    public void addPhone(Phone.Entity phone)
    {
        this.Phones.Add(phone);
    }
}
