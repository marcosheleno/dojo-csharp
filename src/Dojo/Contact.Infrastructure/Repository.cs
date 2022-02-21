using System.Text.RegularExpressions;
using Contact.Domain;
using Group = Contact.Domain.Group;
using Phone = Contact.Domain.Phone;
using Email = Contact.Domain.Email;
using Contact.Domain.Contracts;
using System.Collections.Generic;
using Archive = Infrastructure.Persistance.Archive;
using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Contact.Infrastructure;
public class Repository : IRepository
{

    public Archive.JsonReader JsonReader { get; set; }
    public Repository(Archive.JsonReader jsonReader)
    {
        JsonReader = jsonReader;
    }

    public List<Entity> getAll()
    {
        // JsonReader = new JsonReader();
        var repoJson = JsonReader.read("contacts.json");

        List<Entity> list = new List<Entity>();

        if (repoJson.Count == 0)
        {
            return list;
        }

        foreach (var item in repoJson)
        {

            Entity entity = new Entity(new Guid(item.id.ToString()), item.name.ToString());
            this.attachGroups(entity, item.groups);
            this.attachPhones(entity, item.phones);
            this.attachEmails(entity, item.emails);

            list.Add(entity);
        }

        return list;
    }

    private void attachGroups(Entity entity, dynamic groups)
    {
        if (groups == null)
        {
            return;
        }

        foreach (var groupItem in groups)
        {
            entity.addGroup(new Group.Entity(groupItem.ToString()));
        }
    }

    private void attachPhones(Entity entity, dynamic phones)
    {
        if (phones == null)
        {
            return;
        }

        foreach (var phoneItem in phones)
        {
            Guid guid = new Guid(phoneItem.id.ToString());
            Int64 phone = Int64.Parse(phoneItem.phone.ToString());
            int ddi = int.Parse(phoneItem.ddi.ToString());
            string type = phoneItem.type.ToString();
            System.Console.WriteLine();
            entity.addPhone(new Phone.Entity(guid, phone, ddi, type));
        }
    }

    private void attachEmails(Entity entity, dynamic emails)
    {
        if (emails == null)
        {
            return;
        }

        foreach (var emailItem in emails)
        {
            entity.addEmail(new Email.Entity(new Guid(emailItem.id.ToString()), emailItem.email.ToString(), emailItem.type.ToString()));
        }
    }
}
