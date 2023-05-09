namespace AddressBookSystem
{
    class program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook(10);


            Contact contact1 = new Contact("Rahul", "lal V K", "Mambaram", "Kannur", "Kerala", "12345", "555-1234", "Rahullal432@gmail.com");
            Contact contact2 = new Contact("Sruthi", "Lakshmi", "Mambaram", "Kannur", "Kannur", "67890", "555-5678", "sruthi@gmail.com");

            addressBook.AddContact(contact1);
            addressBook.AddContact(contact2);
            addressBook.DisplayContacts();
            Console.ReadLine();
        }
    }
}