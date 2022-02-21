using ObjectModel = System.Collections.ObjectModel;

namespace Contact.Domain.Group;

public class Collection
{
    private ObjectModel.Collection<Entity> _groups;

    public Collection()
    {
        this._groups = new ObjectModel.Collection<Entity>();
    }

    public virtual void Add(Entity entity)
    {
        this._groups.Add(entity);
    }

    public bool IsEmpty()
    {
        return this._groups.Count == 0;
    }
}
