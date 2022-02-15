namespace Contact.Domain.Email
{
    class Entity : BaseClass
    {
        private string email;
        private string type;

        public Entity(Guid id, string email, string type)
        {
            this.id = id;
            this.email = email;
            this.type = type;
        }

    }
}
