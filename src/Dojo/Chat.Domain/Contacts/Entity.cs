namespace Chat.Domain.Contacts
{
    class Entity : BaseClass
    {
        public string Name {get; set;}

        public Entity(Guid id, string name)
        {
            Id = id;
            _name = name;
        }
    }
}
