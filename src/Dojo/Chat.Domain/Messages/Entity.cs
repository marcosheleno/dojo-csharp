namespace Chat.Domain.Messages
{
    public class Entity : BaseClass
    {
        public DateTime _date_time {get; set;}
        public string _type {get; set;}

        public Entity()
        {
        
        }

        public Entity(Guid id, DateTime date_time, string type)
        {
            Id = id;
            _date_time = date_time;
            _type = type;
        }
    }
}
