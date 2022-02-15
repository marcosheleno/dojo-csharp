namespace Chat.Domain.Contacts
{
    class Entity : BaseClass
    {
        private string name;

        public Entity(Guid id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}