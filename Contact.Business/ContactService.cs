using Contact.DataAccess;
using System;

namespace Contact.Business
{
    public class ContactService : IContactService
    {
        public Models.Contact GetContact()
        {
            return new Models.Contact()
            {
                Id =1,
                FirstName = "Baran",
                LastName = "Ucdag"
            };
        }

        public Models.Contact GetContactById(int id)
        {
            return new Models.Contact()
            {
                Id = id,
                FirstName = "Salih",
                LastName = "Cantekin"
            };
        }
    }
}
