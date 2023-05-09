namespace AddressBookSystem
{
    class program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook(10);

            Contact contact1 = new Contact("John", "Doe", "123 Main St", "City1", "State1", "12345", "555-1234", "john@example.com");
            Contact contact2 = new Contact("Jane", "Smith", "456 Elm St", "City2", "State2", "67890", "555-5678", "jane@example.com");

            addressBook.AddContact(contact1);
            addressBook.AddContact(contact2);

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
            addressBook.AddContact(newContact);

            Console.WriteLine("Contacts in the address book:");
            addressBook.DisplayContacts();

            Console.ReadLine();
        }
    }
}
