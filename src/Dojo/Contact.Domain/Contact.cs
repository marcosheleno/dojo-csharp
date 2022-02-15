using static Contact.Domain.Email.Entity;
namespace Contact.Domain
{
    class Contact : BaseClass
    {
        private string name;

        private Entity email;

        public Contact(Guid id, string name)
        {
            this.id = id;
            this.name = name;
            this.Email = new Entity();
        }
    }
}
