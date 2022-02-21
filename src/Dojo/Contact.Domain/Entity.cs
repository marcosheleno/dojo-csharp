using System;
using System.Collections.ObjectModel;
using Email = Contact.Domain.Email;
using Group = Contact.Domain.Group;
using Phone = Contact.Domain.Phone;

namespace Contact.Domain;

public class Entity : BaseClass
{
    public string Name { get; set; }

    public Email.Collection Emails { get; set; }

    public Group.Collection Groups { get; set; }

    public Phone.Collection Phones { get; set; }

    public Entity(Guid id, string name)
    {
        Id = id;
        Name = name;
        Groups = new Group.Collection();
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
