namespace Contact.Domain.Phone
{
    public class Entity : BaseClass
    {
        private int _phone { get; set; }
        private int _ddi { get; set; }
        private string _type { get; set; }

        public Entity()
        {

        }

        public Entity(Guid id, int phone, int ddi, string type)
        {
            this.Id = id;
            _phone = phone;
            _ddi = ddi;
            _type = type;
        }

        public int Phone
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
