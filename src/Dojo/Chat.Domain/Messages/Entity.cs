namespace Contact.Domain.Messages
{
    class Entity : BaseClass
    {
        private string date_time;
        private string type;

        public Entity(Guid id, string date_time, string type)
        {
            this.id = id;
            this.date_time = date_time;
            this.type = type;
        }
    }
}
