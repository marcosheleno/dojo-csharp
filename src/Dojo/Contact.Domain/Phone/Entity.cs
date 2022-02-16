namespace Contact.Domain.Phone
{
    public class Entity : BaseClass
    {
        private int phone;
        private int ddi;
        private string type;

        public Entity(Guid id, int phone, int ddi, string type)
        {
            this.id = id;
            this.phone = phone;
            this.ddi = ddi;
            this.type = type;
        }
    }
}
