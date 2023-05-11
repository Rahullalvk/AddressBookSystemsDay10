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
        private Contact[] contacts;
        private int count;

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

        public void EditContact(string firstName, string lastName)
        {
            Contact contact = FindContact(firstName, lastName);
            if (contact != null)
            {
                Console.WriteLine($"Editing contact: {contact.FirstName} {contact.LastName}");

                Console.WriteLine("Enter the updated details:");
                Console.Write("Address: ");
                contact.Address = Console.ReadLine();
                Console.Write("City: ");
                contact.City = Console.ReadLine();
                Console.Write("State: ");
                contact.State = Console.ReadLine();
                Console.Write("Zip: ");
                contact.Zip = Console.ReadLine();
                Console.Write("Phone Number: ");
                contact.PhoneNumber = Console.ReadLine();
                Console.Write("Email: ");
                contact.Email = Console.ReadLine();

                Console.WriteLine("Contact updated successfully.");
            }
            else
            {
                Console.WriteLine($"Contact with name '{firstName} {lastName}' not found.");
            }
        }

        private Contact FindContact(string firstName, string lastName)
        {
            foreach (var contact in contacts)
            {
                if (contact != null && contact.FirstName == firstName && contact.LastName == lastName)
                {
                    return contact;
                }
            }
            return null;
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