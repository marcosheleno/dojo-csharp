namespace Chat.Domain.Contacts;

public class Entity : BaseClass
{
    public string Name { get; set; }

    public Entity()
    {

    }
    public Entity(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
    public Entity(int id, string name)
    {
        Name = name;
    }
}
