using System;

namespace AddressBookServiceADO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Address Book Service");
            AddressBookRepository repository = new AddressBookRepository();
            ContactDetails details = new ContactDetails();
            repository.CountOfContacts();
        }
    }
}