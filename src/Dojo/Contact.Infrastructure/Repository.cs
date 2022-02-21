using System.Text.RegularExpressions;
using Contact.Domain;
using Group = Contact.Domain.Group;
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
        var repoJson = JsonReader.read("");

        List<Entity> list = new List<Entity>();

        if (repoJson.Count == 0)
        {
            return list;
        }

        foreach (var item in repoJson)
        {

            Entity entity = new Entity(new Guid(item.id.ToString()), item.name.ToString());
            this.attachGroups(entity, item.groups);

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
}
