using ObjectModel = System.Collections.ObjectModel;

namespace Contact.Domain.Email;

public class Collection
{
    private ObjectModel.Collection<Entity> _emails;

    public Collection()
    {
        this._emails = new ObjectModel.Collection<Entity>();
    }

    public virtual void Add(Entity entity)
    {
        this._emails.Add(entity);
    }
}
