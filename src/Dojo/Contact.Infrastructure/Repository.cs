using Contact.Domain;
using Contact.Domain.Contracts;
using Infrastructure.Persistance.Archive;

using Newtonsoft.Json.Linq;
namespace Contact.Infrastructure;
public class Repository : IRepository
{

    
    public Repository()
    {

    }

    public Entity[] getAll()
    {
        JsonReader jsonReader = new JsonReader();
        JObject repoJson = jsonReader.Json;

        Entity[] contacts;
        for (int i = 0; i < repoJson.Lenght; i++)
            {
                Guid id =  Guid.NewGuid();
                Entity contact = Entity(id, repoJson[i].name);
                if(repoJson[i].email){
                    contact.addEmail(repoJson[i].email);   
                }
                if(repoJson[i].group){
                    contact.addEmail(repoJson[i].group);   
                }
                if(repoJson[i].phones){
                    contact.addEmail(repoJson[i].phones);   
                }
                contacts[i] = contact;
            }
        
    }
}
