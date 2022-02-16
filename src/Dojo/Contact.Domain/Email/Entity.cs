namespace Contact.Domain.Email;

public class Entity : BaseClass
{
    private string _email { get; set; }
    private string _type { get; set; }

    public Entity()
    {

    }

    public Entity(Guid id, string email, string type)
    {
        Id = id;
        _email = email;
        _type = type;
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }

}
