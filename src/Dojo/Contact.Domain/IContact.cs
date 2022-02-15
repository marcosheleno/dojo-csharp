namespace Contact.Domain
{
    public interface IContact
    {
        protected int ID { get; set; }
        protected string Name { get; set; }
        protected string Emails { get; set; }
        protected int Telefones { get; set; }
    }
}