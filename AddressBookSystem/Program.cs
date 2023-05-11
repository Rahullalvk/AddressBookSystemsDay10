namespace AddressBookSystem
{
  public  class program
    {
        static void Main(string[] args)
        {

            AddressBooks addressBooks = new AddressBooks(10);
            Contact contact1 = new Contact("Rahul", "lal V K", "Mambaram", "Kannur", "Kerala", "12345", "555-1234", "Rahullal432@gmail.com");
            Contact contact2 = new Contact("Sruthi", "Lakshmi", "Mambaram", "Kannur", "Kannur", "67890", "555-5678", "sruthi@gmail.com");

            addressBooks.AddContact(contact1);
            addressBooks.AddContact(contact2);

            Console.WriteLine("Address Book:");
            addressBooks.DisplayContacts();

            Console.WriteLine("Enter the details of the new contact:");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("State: ");
            string state = Console.ReadLine();
            Console.Write("Zip: ");
            string zip = Console.ReadLine();
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Contact newContact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            addressBooks.AddContact(newContact);

            Console.WriteLine("Address Book after adding a new contact:");
            addressBooks.DisplayContacts();

            Console.WriteLine("Enter the first name of the contact to edit:");
            string editFirstName = Console.ReadLine();
            Console.WriteLine("Enter the last name of the contact to edit:");
            string editLastName = Console.ReadLine();
            addressBooks.EditContact(editFirstName, editLastName);

            Console.WriteLine("Address Book after editing a contact:");
            addressBooks.DisplayContacts();

            Console.WriteLine("Enter the first name of the contact to delete:");
            string deleteFirstName = Console.ReadLine();
            Console.WriteLine("Enter the last name of the contact to delete:");
            string deleteLastName = Console.ReadLine();
            addressBooks.DeleteContact(deleteFirstName, deleteLastName);

            Console.WriteLine("Address Book after deleting a contact:");
            addressBooks.DisplayContacts();

            Console.ReadLine();
        }
    }
}
