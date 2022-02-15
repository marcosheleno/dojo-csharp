namespace Chat.Domain
{
  class Chat : BaseClass
    {
        private string name;

        private Contact contact_id;
        private Messages.Entity[] messages;


        public Chat(Guid id)
        {
            this.id = id;
       
        }
    }
}
