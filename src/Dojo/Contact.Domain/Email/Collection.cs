using ObjectModel = System.Collections.ObjectModel;

namespace Contact.Domain.Email;

public class Collection
{
    public ObjectModel.Collection<Entity> Emails {get;} 

    public Collection()
    {
        this.Emails = new ObjectModel.Collection<Entity>();
    }

    public virtual void Add(Entity entity)
    {
        this.Emails.Add(entity);
    }

    public bool IsEmpty()
    {
        return this.Emails.Count == 0;
    }
}
