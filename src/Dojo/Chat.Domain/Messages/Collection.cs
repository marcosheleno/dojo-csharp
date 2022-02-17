using ObjectModel = System.Collections.ObjectModel;

namespace Chat.Domain.Messages;

public class Collection
{
    private ObjectModel.Collection<Entity> _messages;

    public Collection()
    {
        this._messages = new ObjectModel.Collection<Entity>();
    }

    public virtual void Add(Entity entity)
    {
        this._messages.Add(entity);
    }
}
