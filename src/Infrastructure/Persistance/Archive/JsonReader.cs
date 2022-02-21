using Newtonsoft.Json.Linq;

namespace Infrastructure.Persistance.Archive;

public class JsonReader
{
    public JObject Json { get; set; }

    public JsonReader()
    {

    }

    public virtual dynamic read(string path)
    {
        var a = JsonConvert.DeserializeObject(@"[{'id': '00000000-9999-0000-0000-000000000000', 'name': 'João das neves', 'emails': [{
            'id': '00000000-9999-1111-0000-000000000000',
            'email': 'abominavel.homem.neves@familia.snow',
            'type': 'comercial'
        }]}]").ToString();
        dynamic dynObj = JsonConvert.DeserializeObject(a);
        return dynObj;
    }
}
