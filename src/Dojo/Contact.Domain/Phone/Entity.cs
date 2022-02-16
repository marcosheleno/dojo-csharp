namespace Contact.Domain.Phone
{
    public class Entity : BaseClass
    {
        private int phone {get; set;}
        private int ddi {get; set;}
        private string type {get; set;}

        public Entity(Guid id, int phone, int ddi, string type)
        {
            this.Id = id;
            this.phone = phone;
            this.ddi = ddi;
            this.type = type;
        }
    }
}
