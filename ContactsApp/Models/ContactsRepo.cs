using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactsApp.Models
{
    public class ContactsRepo : IContactsRepo
    {
        private readonly List<Contacts> _contacts;

        public ContactsRepo()
        {
            _contacts = new List<Contacts>()
            {
                new Contacts() {Name = "sam", Email = new []{"sam@gmail.com", "samo@yahoo.com"}, Number = new []{"07037465260"}},
                new Contacts() {Name = "Ola", Email = new []{"ola@gmail.com"}, Number = new []{"08033822928"}},
                new Contacts() {Name = "Yemi", Email = new []{"yemi@gmail.com"}, Number = new []{"09091691407"}},
                new Contacts() {Name = "bolaji", Email = new []{"bolaji@gmail.com"}, Number = new []{"08026157325"}}
            };
        }

        
        public Contacts GetContact(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Value cannot be null or empty.", nameof(name));

            return _contacts.FirstOrDefault(c => c.Name == name);
        }

        public IEnumerable<Contacts> GetAllContacts()
        {
            return _contacts;
        }
    }
}