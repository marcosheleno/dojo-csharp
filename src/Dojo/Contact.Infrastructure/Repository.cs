using Contact.Domain;
using Contact.Domain.Contracts;
using System.Collections.Generic;
using Infrastructure.Persistance.Archive;

using Newtonsoft.Json.Linq;
namespace Contact.Infrastructure;
public class Repository : IRepository
{

    public JsonReader JsonReader { get; set; }
    public Repository(JsonReader jsonReader)
    {
        JsonReader = jsonReader;
    }

    public List<Entity> getAll()
    {
        List<Entity> list = new List<Entity>();
        // JsonReader = new JsonReader();
        JObject repoJson = JsonReader.read("");

        foreach (JObject item in repoJson)
            {
                Guid id =  item.id;
                string name = item.name;

                Entity contact = new Entity(id, name);

                list.Add(contact);
                
            }
        return list;
    }
}
