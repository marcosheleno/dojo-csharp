using Newtonsoft.Json.Linq;

namespace Infrastructure.Persistance.Archive;

public class JsonReader
{
    public JObject Json { get; set; }

    // string JsonFile = @"[
    //                         {
    //                             'id': 10,
    //                             'name': 'João das Neves',
    //                             'group': [
    //                                 'familia neves'
    //                             ],
    //                             'phones': [
    //                                 {
    //                                     'phone': 456465456,
    //                                     'ddi': 55,
    //                                     'type': 'residencial'
    //                                 }
    //                             ]
    //                         },
    //                         {
    //                             'id': 15,
    //                             'name': 'Branc de Neves',
    //                             'group': [
    //                                 'familia neves'
    //                             ],
    //                             'phones': [
    //                                 {
    //                                     'phone': 56498412398,
    //                                     'ddi': 1,
    //                                     'type': 'celular'
    //                                 }
    //                             ]
    //                         },
    //                         {
    //                             'id': 5,
    //                             'name': 'Abominável Homem das Neves',
    //                             'group': [
    //                                 'familia neves'
    //                             ],
    //                             'emails': [
    //                                 {
    //                                     'email': 'abominavel.homem.neves@familia.snow',
    //                                     'type': 'comercial'
    //                                 }
    //                             ],
    //                             'phones': [
    //                                 {
    //                                     'phone': 54516885,
    //                                     'ddi': 55,
    //                                     'type': 'fax'
    //                                 }
    //                             ]
    //                         }
    //                     ]";
    // JObject jObject = JObject.Parse(JsonFile);
    // JObject Json = jObject;
    public JsonReader()
    {

    }

    public virtual dynamic read(string path)
    {
        return "";
    }
}
