namespace Chat.Domain;

{
  class Chat : BaseClass
    {
        private Contacts.Entity _contact;
        private Messages.Collection _messages;


        public Chat(Guid id, Contacts.Entity contact, Messages.Entity[] messages) 
        {
            Id = id;
            _contact = contact;
            _messages = messages;
        }
    }
}
