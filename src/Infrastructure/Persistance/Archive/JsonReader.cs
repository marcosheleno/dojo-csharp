using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace Infrastructure.Persistance.Archive;

public class JsonReader
{
    public JObject Json { get; set; }

    public JsonReader()
    {

    }

    public virtual dynamic read(string path)
    {
        using (StreamReader r = new StreamReader("../" + path))
        {
            string json = r.ReadToEnd();
            var a = JsonConvert.DeserializeObject(json).ToString();
            dynamic dynObj = JsonConvert.DeserializeObject(a);
            return dynObj;
        }

    }
}
