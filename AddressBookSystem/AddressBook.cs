using AddressBookSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
   public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void DisplayContact()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"State: {State}");
            Console.WriteLine($"Zip: {Zip}");
            Console.WriteLine($"Phone: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine("-----------------------------------");
        }
    }

   public  class AddressBooks
    {
        private Contact[] contacts;
        private int count;

        public AddressBooks(int capacity)
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

        public void DeleteContact(string firstName, string lastName)
        {
            for (int i = 0; i < count; i++)
            {
                if (contacts[i] != null && contacts[i].FirstName == firstName && contacts[i].LastName == lastName)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }
                    contacts[count - 1] = null;
                    count--;
                    Console.WriteLine($"Contact '{firstName} {lastName}' deleted successfully.");
                    return;
                }
            }
            Console.WriteLine($"Contact with name '{firstName} {lastName}' not found.");
        }

        public Contact FindContact(string firstName, string lastName)
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
    }
}




