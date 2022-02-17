namespace Contact.Domain.Group
{
    public class Entity : BaseClass
    {
        private string _groupName {get; set;}


        public Entity()
        {
        
        }
        
        public Entity(string groupName)
        {
            _groupName = groupName;
        }

        public string GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }
    }
}
