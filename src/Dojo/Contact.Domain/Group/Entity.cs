namespace Contact.Domain.Group
{
    public class Entity : BaseClass
    {
        private string groupName {get; set;}

        public Entity(string groupName)
        {
            this.groupName = groupName;
        }
    }
}
