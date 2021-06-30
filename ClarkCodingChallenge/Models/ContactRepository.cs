using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.Models
{
    // Represents current list/repository of email contacts
    public class ContactRepository
    {
        // List of contacts
        private List<ContactModel> _contactList;

        // Constructor
        public ContactRepository()
        {
            _contactList = new List<ContactModel>();
        }

        // Getter for _contactList
        public List<ContactModel> GetContactList()
        {
            return _contactList;
        }

        // Adds a new contact to the list of contacts
        // Param: A contact (likely without its id) to be added to the list
        // Returns: A contact (with updated id)
        public ContactModel Add(ContactModel contact)
        {
            if (_contactList.Count <= 0) { contact.Id = 1; }
            else { contact.Id = _contactList.Max(c => c.Id) + 1; }
            _contactList.Add(contact);
            return contact;
        }
    }
}
