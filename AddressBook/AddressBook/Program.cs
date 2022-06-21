using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            Console.WriteLine("-----------------------");

            ContactOperation contactOperation = new ContactOperation();
            contactOperation.addContact("Vaibhav", "Manapure", "At.Po.Ta Samudrapur,Wardha", "Nagpur", "Maharashtra", "442305", "9764510067", "manapure.vaibhav542@gmail.com");
            contactOperation.showList();

            Console.ReadKey();
        }
    }
}
