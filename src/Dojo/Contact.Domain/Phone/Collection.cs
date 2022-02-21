using ObjectModel = System.Collections.ObjectModel;

namespace Contact.Domain.Phone;

public class Collection
{
    public ObjectModel.Collection<Entity> Phones {get;}

    public Collection()
    {
        this.Phones = new ObjectModel.Collection<Entity>();
    }

    public virtual void Add(Entity entity)
    {
        this.Phones.Add(entity);
    }

    public bool IsEmpty()
    {
        return this.Phones.Count == 0;
    }
}
