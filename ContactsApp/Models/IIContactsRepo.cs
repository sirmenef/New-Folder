using System.Collections;
using System.Collections.Generic;

namespace ContactsApp.Models
{
    public interface IContactsRepo
    {
        Contacts GetContact(string name);
        IEnumerable<Contacts> GetAllContacts();
    }
}