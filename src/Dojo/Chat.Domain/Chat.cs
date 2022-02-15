namespace Chat.Domain
{
  class Chat : BaseClass
    {
        private string name;

        private Contacts.Entity contact;
        private Messages.Entity[] messages;


        public Chat(Guid id, Contacts.Entity contact, Messages.Entity[] messages)
        {
            this.id = id;
            this.contact = contact;
            this.messages = messages;
        }
    }
}
