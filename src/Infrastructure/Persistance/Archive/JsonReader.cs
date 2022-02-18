using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace Infrastructure.Persistance.Archive;

static void JsonReader()
{
    JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

    using (StreamReader r = new StreamReader(@"../../../contacts.json"))
    {
        string json = r.ReadToEnd();
        dynamic array = serializer.DeserializeObject(json);
        Console.WriteLine("");
        Console.WriteLine(serializer.Serialize(array));
        Console.WriteLine("");
        Console.ReadKey();
    }
}
