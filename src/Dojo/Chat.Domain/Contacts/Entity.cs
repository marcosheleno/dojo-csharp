namespace Chat.Domain.Contacts;

public class Entity : BaseClass
{
        public string Name {get; set;}

    public Entity(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}
