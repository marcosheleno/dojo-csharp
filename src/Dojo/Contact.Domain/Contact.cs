namespace Contact.Domain
{
    class Contact : BaseClass
    {
        private string name;

        public Contact(Guid id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
