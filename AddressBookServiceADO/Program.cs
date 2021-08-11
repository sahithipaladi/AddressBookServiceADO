using System;
using System.Collections.Generic;

namespace AddressBookServiceADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book Service");
            AddressBookRepository repository = new AddressBookRepository();
            ContactDetails details = new ContactDetails();
            details.FirstName = "Ashwin";
            details.LastName = "K";
            details.Address = "SKD Colony";
            details.City = "Adoni";
            details.State = "AndhraPradesh";
            details.zip = 525678;
            details.PhoneNumber = 6302921479;
            details.Email = "ashwin@gmail.com";
            details.ContactType = "Professsion";
            details.AddressBookName = "Office";
            bool result = repository.AddContact(details);
            if (result)
                Console.WriteLine("Contact added successfully");
            else
                Console.WriteLine("Contact not added");

            ThreadOperations threadOperations = new ThreadOperations();
            List<ContactDetails> contactList = new List<ContactDetails>();
            contactList.Add(details);

            //Add list of contacts to DB without thread
            threadOperations.AddContactListToDBWithoutThread(contactList);
            //Add list of contacts to DB with thread
            threadOperations.AddContactListToDBWithThread(contactList);
        }
    }
}
