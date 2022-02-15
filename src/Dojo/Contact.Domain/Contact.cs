namespace Contact.Domain
{
    public class Contact : IContact
    {
        
        int IContact.ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IContact.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IContact.Emails { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IContact.Telefones { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        static void IContact() {
            
            
        }
    }
}