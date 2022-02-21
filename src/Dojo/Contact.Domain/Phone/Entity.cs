using System;

namespace Contact.Domain.Phone
{
    public class Entity : BaseClass
    {
        public Int64 _phone { get; set; }
        public int _ddi { get; set; }
        public string _type { get; set; }

        public Entity()
        {

        }

        public Entity(Guid id, Int64 phone, int ddi, string type)
        {
            this.Id = id;
            _phone = phone;
            _ddi = ddi;
            _type = type;
        }

        public Int64 Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public int Ddi
        {
            get { return _ddi; }
            set { _ddi = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
