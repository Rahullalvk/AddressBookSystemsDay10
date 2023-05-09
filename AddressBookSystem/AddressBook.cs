using AddressBookSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook
    {
        public Contact[] contacts;
        public int count;

        public AddressBook(int capacity)
        {
            contacts = new Contact[capacity];
            count = 0;
        }

        public void AddContact(Contact contact)
        {
            if (count < contacts.Length)
            {
                contacts[count] = contact;
                count++;
                Console.WriteLine("Contact added successfully.");
            }
            else
            {
                Console.WriteLine("Address book is full. Unable to add contact.");
            }
        }

        public void DisplayContacts()
        {
            for (int i = 0; i < count; i++)
            {
                contacts[i].DisplayContact();
            }
        }
    }
}
