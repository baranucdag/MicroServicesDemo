namespace Contact.DataAccess
{
    public interface IContactService
    {
        public Models.Contact GetContact();
        public Models.Contact GetContactById(int id);
    }
}
