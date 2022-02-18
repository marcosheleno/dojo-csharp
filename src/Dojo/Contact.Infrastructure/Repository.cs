using Contact.Domain;
using Contact.Domain.Contracts;
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

    public Entity[] getAll()
    {
        // JsonReader = new JsonReader();
        JObject repoJson = JsonReader.read("");

        // Entity[] contacts;
        // for (int i = 0; i < repoJson.Lenght; i++)
        //     {
        //         Guid id =  Guid.NewGuid();
        //         Entity contact = Entity(id, repoJson[i].name);
        //         if(repoJson[i].email){
        //             contact.addEmail(repoJson[i].email);   
        //         }
        //         if(repoJson[i].group){
        //             contact.addEmail(repoJson[i].group);   
        //         }
        //         if(repoJson[i].phones){
        //             contact.addEmail(repoJson[i].phones);   
        //         }
        //         contacts[i] = contact;
        //     }
        Entity[] myArray = new Entity[]{};
        return myArray;
    }
}
