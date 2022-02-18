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

        System.Console.WriteLine(repoJson);

        return getAll();
    }
}
