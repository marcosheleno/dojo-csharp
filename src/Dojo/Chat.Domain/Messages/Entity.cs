namespace Chat.Domain.Messages
{
    public class Entity : BaseClass
    {
        private string _date_time {get; set;}
        private string _type {get; set;}

        public Entity()
        {
        
        }

        public Entity(Guid id, string date_time, string type)
        {
            this.id = id;
            this._date_time = date_time;
            this._type = type;
        }

        public string Data_Time
        {
            get { return _date_time; }
            set { _date_time = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
