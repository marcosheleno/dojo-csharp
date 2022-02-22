using System;

namespace Contact.Domain.Phone
{
    public class Entity : BaseClass
    {
        public Int64 Phone { get; set; }
        public int Ddi { get; set; }
        public string Type { get; set; }

        public Entity()
        {

        }

        public Entity(Guid id, Int64 phone, int ddi, string type)
        {
            this.Id = id;
            Phone = phone;
            Ddi = ddi;
            Type = type;
        }
    }
}
