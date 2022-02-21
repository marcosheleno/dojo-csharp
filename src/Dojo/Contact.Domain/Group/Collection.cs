using ObjectModel = System.Collections.ObjectModel;

namespace Contact.Domain.Group;

public class Collection
{
    public ObjectModel.Collection<Entity> Groups {get;}

    public Collection()
    {
        this.Groups = new ObjectModel.Collection<Entity>();
    }

    public virtual void Add(Entity entity)
    {
        this.Groups.Add(entity);
    }

    public bool IsEmpty()
    {
        return this.Groups.Count == 0;
    }
}
