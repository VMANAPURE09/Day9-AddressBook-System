using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contacts
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string phonenumber { get; set; }
        string city { get; set; }
        string state { get; set; }
        string Zip { get; set; }
        string address { get; set; }

        public List<Contacts> People = new List<Contacts>();
        public void addperson()
        {

            Contacts person = new Contacts();


            Console.WriteLine("Add a entry to your Address book");


            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.phonenumber = Console.ReadLine();

            Console.Write("Enter Address 1: ");

            person.address = Console.ReadLine();
            Console.Write("Enter Zip: ");
            person.Zip = Console.ReadLine();

            Console.Write("Enter city: ");
            person.city = Console.ReadLine();

            Console.Write("Enter state: ");
            person.state = Console.ReadLine();


            People.Add(person);
        }
    }
}
