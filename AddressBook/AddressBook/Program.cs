using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            Console.WriteLine("-----------------------");
            Console.WriteLine("--Add Contact Details--");

            Console.WriteLine("First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Address:");
            string address = Console.ReadLine();
            Console.WriteLine("City:");
            string city = Console.ReadLine();
            Console.WriteLine("State:");
            string state = Console.ReadLine();
            Console.WriteLine("Zip Code:");
            string zip = Console.ReadLine();
            Console.WriteLine("Phone Number:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Email Address:");
            string email = Console.ReadLine();


            //ContactOperation contactOperation = new ContactOperation();
            //contactOperation.addContact("Vaibhav", "Manapure", "At.Po.Ta Samudrapur,Wardha", "Nagpur", "Maharashtra", "442305", "9764510067", "manapure.vaibhav542@gmail.com");
            //contactOperation.showList();

            Console.ReadKey();
        }
    }
}
