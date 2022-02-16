namespace Contact.Domain
{
    public class BaseClass
    {
        protected Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { _id = Guid.NewGuid(); }
        }
    }
}
