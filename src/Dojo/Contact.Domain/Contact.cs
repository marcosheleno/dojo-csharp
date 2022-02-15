namespace Contact.Domain
{
  class Contact : BaseClass
    {
        private string name;

        private Email.Entity[]? emails;
        private Phone.Entity[]? phones;

        private Group.Entity[]? groups;

        public Contact(Guid id, string name, Email.Entity[]? emails, Phone.Entity[]? phones, Group.Entity[]? groups)
        {
            this.id = id;
            this.name = name;
            this.emails = emails;
            this.phones = phones;
            this.groups = groups;
        }

        public Guid getId(){
            return this.id;
        }
    }
}
