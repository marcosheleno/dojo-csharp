namespace Contact.Domain.Email
{
    public class Entity : BaseClass
    {
        private string _Email {get; set;}
        private string _Type {get; set;}

        public Entity(Guid id, string email, string type)
        {
            this.Id = id;
            this.Email = email;
            this.Type = type;
        }

        public Email getEmail
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public Email getTypeEmail
        {
            get { return _Type; }
            set { _Type = value; }
        }

    }
}
