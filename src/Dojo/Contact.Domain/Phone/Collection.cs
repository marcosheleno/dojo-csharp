using ObjectModel = System.Collections.ObjectModel;

namespace Contact.Domain.Phone;

public class Collection
{
    private ObjectModel.Collection<Entity> _phones;

    public Collection()
    {
        this._phones = new ObjectModel.Collection<Entity>();
    }

    public virtual void Add(Entity entity)
    {
        this._phones.Add(entity);
    }

    public bool IsEmpty()
    {
        return this._phones.Count == 0;
    }
}
