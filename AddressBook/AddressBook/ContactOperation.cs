﻿using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class ContactOperation
    {
        // Creating list for Storing the Contacts of Each Persons details
        List<Contact> AddressList = new List<Contact>();


        Dictionary<string, List<Contact>> MultipleAddressbook = new Dictionary<string, List<Contact>>();

        //Creating the method for creating the contact
        public void AddContact(Contact newcontact)
        {
            AddressList.Add(newcontact);
           
        }
        public void Editexistingcontact()
        {
            Console.WriteLine("Enter first name of person you want to edit");
            string name = Console.ReadLine();
            foreach (var contact in AddressList)
            {
                if (contact.firstname == name)
                {
                    Console.WriteLine("Enter number : \n 1. First name \n 2. Last name \n 3. Address \n 4. City \n 5. State \n 6. Zip code \n 7. Phone Number \n 8. Email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter new firstname");
                            string first = Console.ReadLine();
                            contact.firstname = first;
                            break;
                        case 2:
                            Console.WriteLine("Enter new lastname");
                            string last = Console.ReadLine();
                            contact.lastname = last;
                            break;
                        case 3:
                            Console.WriteLine("Enter new address");
                            string address = Console.ReadLine();
                            contact.address = address;
                            break;
                        case 4:
                            Console.WriteLine("Enter new city");
                            string city = Console.ReadLine();
                            contact.city = city;
                            break;
                        case 5:
                            Console.WriteLine("Enter new state");
                            string state = Console.ReadLine();
                            contact.state = state;
                            break;
                        case 6:
                            Console.WriteLine("Enter new zip");
                            string zip = Console.ReadLine();
                            contact.zip = zip;
                            break;
                        case 7:
                            Console.WriteLine("Enter new phonenumber");
                            string phone = Console.ReadLine();
                            contact.phonenumber = phone;
                            break;
                        case 8:
                            Console.WriteLine("Enter new emailid");
                            string email = Console.ReadLine();
                            contact.emailid = email;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public void Deletecontact()
        {
            Console.WriteLine("Enter first name you want delete");
            string name = Console.ReadLine();
            Contact delete = new Contact();
            foreach (var contact in AddressList)
            {
                if (contact.firstname == name)
                {
                    AddressList.Remove(contact);
                    Console.WriteLine(name + " contact is deleted");
                    break;
                }
            }
        }
        public void Display()
        {
            foreach (var contact in AddressList)
            {
                Console.WriteLine("\nfirstname: " + contact.firstname + "\nlastname: " + contact.lastname + "\naddress: " + contact.address + "\ncity: " + contact.city + "\nstate: " + contact.state + "\nzip: " + contact.zip + "\nphoneno: " + contact.phonenumber + "\nemail: " + contact.emailid);
            }
        }
        public void AddUniqueContact(string uniquename)
        {
            foreach (var contact in AddressList)
            {
                if (contact.firstname.Equals(uniquename))
                {
                    Contact multiplecontact = new Contact();

                    Console.WriteLine("Contact already exist , Enter unique name");
                    multiplecontact.firstname = Console.ReadLine();
                    multiplecontact.lastname = Console.ReadLine();
                    multiplecontact.address = Console.ReadLine();
                    multiplecontact.city = Console.ReadLine();
                    multiplecontact.state = Console.ReadLine();
                    multiplecontact.zip = Console.ReadLine();
                    multiplecontact.phonenumber = Console.ReadLine();
                    multiplecontact.emailid = Console.ReadLine();
                    AddContact(multiplecontact);
                }
            }
        }
        public void DisplayUniqueContacts()
        {
            Console.WriteLine("enter name of dictionary to display that contact details");
            string name = Console.ReadLine().ToLower();
            foreach (var contacts in MultipleAddressbook)
            {
                if (contacts.Key == name)
                {
                    foreach (var data in contacts.Value)
                    {
                        Console.WriteLine("The Contact of " + data.firstname + " Details are\n:" + data.firstname + " " + data.lastname + " " + data.address + " " + data.city + " " + data.state + " " + data.zip + " " + data.phonenumber + " " + data.emailid);
                    }
                }
            }
            Console.WriteLine("UniqueContacts does not exist... Please create a UniquecontactList");
            return;
        }
        public void Search_person_city_state()
        {
            Console.WriteLine("Enter your Choice for Searching a Person in");
            Console.WriteLine("\n1.City \n2.State");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter City Name:");
                    String City = Console.ReadLine();

                    foreach (Contact data in this.AddressList.FindAll(e => e.city == City))
                    {
                        Console.WriteLine(data.firstname + " " + data.lastname + " is from " + data.city);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter State Name:");
                    String State = Console.ReadLine();

                    foreach (Contact data in this.AddressList.FindAll(e => e.state == State))
                    {
                        Console.WriteLine(data.firstname + " " + data.lastname + " is from " + data.state);
                    }
                    break;

            }


        }
        public void view_person_city_state()
        {
            Console.WriteLine("Enter your Choice for a Person view in");
            Console.WriteLine("\n1.City \n2.State");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter City Name:");
                    String City = Console.ReadLine();

                    foreach (Contact data in this.AddressList.FindAll(e => e.city == City))
                    {
                        Console.WriteLine(data.firstname + " " + data.lastname + " is from " + data.city);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter State Name:");
                    String State = Console.ReadLine();

                    foreach (Contact data in this.AddressList.FindAll(e => e.state == State))
                    {
                        Console.WriteLine(data.firstname + " " + data.lastname + " is from " + data.state);
                    }
                    break;

            }


        }
        public void Count_person_city_state()
        {
            int count = 0;
            Console.WriteLine("Enter your Choice for Searching a Person in");
            Console.WriteLine("\n1.City \n2.State");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter your City");
                    String city = Console.ReadLine();
                    foreach (Contact personal_Details in this.AddressList.FindAll(c => c.city == city))
                    {
                        count = this.AddressList.Count();
                    }
                    Console.WriteLine(count);
                    break;
                case 2:
                    Console.WriteLine("Enter your State");
                    String state = Console.ReadLine();
                    foreach (Contact personal_Details in this.AddressList.FindAll(c => c.state == state))
                    {
                        count = this.AddressList.Count();
                    }
                    Console.WriteLine(count);
                    break;
            }

        }
        public void SortbyName()
        {
            foreach (KeyValuePair<string, List<Contact>> sortname in MultipleAddressbook.OrderBy(key => key.Key))
            {
                Console.WriteLine("Name of person: {0}", sortname.Key);
            }

        }
        public void SortByCity_State_Zip()
        {
            Console.WriteLine("Write Function to Sort Person by");
            Console.WriteLine("\n1.City \n2.State \n3.Zip");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                   
                    foreach (KeyValuePair<string, List<Contact>> sortbycity in MultipleAddressbook.OrderBy(key => key.Key))
                    {
                        Console.WriteLine("Name of person: {0}", sortbycity.Key);
                    }
                    break;
                case 2:
                    foreach (KeyValuePair<string, List<Contact>> sortbystate in MultipleAddressbook.OrderBy(key => key.Key))
                    {
                        Console.WriteLine("Name of person: {0}", sortbystate.Key);
                    }
                    break;
                case 3:
                    foreach (KeyValuePair<string, List<Contact>> sortbyzip in MultipleAddressbook.OrderBy(key => key.Key))
                    {
                        Console.WriteLine("Name of person: {0}", sortbyzip.Key);
                    }

                    break;
            }

        }
        public void Readfile()
        {
            Console.WriteLine("The Contact List Using Stream Reader");
            string filepath = @"E:\BridgeLabz2\PraticeProblem\Day9-AddressBook-System\AddressBook\AddressBook\ContactOperation.cs";

            using (StreamReader reader = File.OpenText(filepath))
            {
                string line = " ";
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        public void WriteUsingStreamWriter()
        {
            Console.WriteLine("The Contact List Using Stream Writer");
            String path = @"E:\BridgeLabz2\PraticeProblem\Day9-AddressBook-System\AddressBook\AddressBook\ContactOperation.cs";
            using (StreamWriter sr = File.AppendText(path))
            {
                foreach (var contact in AddressList)
                {
                    sr.WriteLine("\nfirstname: " + contact.firstname + "\nlastname: " + contact.lastname + "\naddress: " + contact.address + "\ncity: " + contact.city + "\nstate: " + contact.state + "\nzip: " + contact.zip + "\nphoneno: " + contact.phonenumber + "\nemail: " + contact.emailid);
                }
            }
        }
        public void ReadWriteasCsv()
        {

            string importFilePath = @"E:\BridgeLabz2\PraticeProblem\Day9-AddressBook-System\AddressBook\AddressBook\Import.csv";
            string exportFilePath = @"E:\BridgeLabz2\PraticeProblem\Day9-AddressBook-System\AddressBook\AddressBook\Export.csv";

            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
            {
                //Reading the user data from CSV file
                var records = csv.GetRecords<Contact>().ToList();
                foreach (var Contact in AddressList)
                {
                    Console.WriteLine("\nfirstname: " + Contact.firstname + "\nlastname: " + Contact.lastname + "\naddress: " + Contact.address + "\ncity: " + Contact.city + "\nstate: " + Contact.state + "\nzip: " + Contact.zip + "\nphoneno: " + Contact.phonenumber + "\nemail: " + Contact.emailid);
                }

                //Writing the User data in to CSV file
                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.CurrentCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
        //Write the Persons details in AddtressBook to CSV file And read from the person details from JSON File.
        public void ReadWriteinJson()
        {
            string importFilePath = @"E:\BridgeLabz2\PraticeProblem\Day9-AddressBook-System\AddressBook\AddressBook\AddressBookImport.Json";
            string exportFilePath = @"E:\BridgeLabz2\PraticeProblem\Day9-AddressBook-System\AddressBook\AddressBook\AddressBookExport.Json";
            using (StreamReader reader = new StreamReader(importFilePath))
            {
                //Reading the user data from JSON file
                var json = reader.ReadToEnd();
                var data = JsonConvert.DeserializeObject<List<Contact>>(json);
                foreach (var contact in data)
                {
                    Console.WriteLine("\nfirstname: " + contact.firstname + "\nlastname: " + contact.lastname + "\naddress: " + contact.address + "\ncity: " + contact.city + "\nstate: " + contact.state + "\nzip: " + contact.zip + "\nphoneno: " + contact.phonenumber + "\nemail: " + contact.emailid);
                }

                //Writing the User data in to JSON file
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, data);
                }
            }
        }


    }
}



