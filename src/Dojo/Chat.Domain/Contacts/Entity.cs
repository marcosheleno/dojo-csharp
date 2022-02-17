namespace Chat.Domain.Contacts
{
    class Entity : BaseClass
    {
        private string _name {get; set;}

        public Entity(Guid id, string name)
        {
            Id = id;
            _name = name;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
