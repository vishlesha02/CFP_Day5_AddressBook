using AddressBook;
using OopsConcept;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class AddressBook
    {

        List<Contact> list = new List<Contact>();
        public void AddContacts()
        {
            Console.WriteLine("Enter the details to add a contact : ");


            Console.WriteLine("Enter The First Name");
            String firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            String lastName = Console.ReadLine();

            Console.WriteLine("Enter Address");
            String address = Console.ReadLine();

            Console.WriteLine("Enter City");
            String city = Console.ReadLine();

            Console.WriteLine("Enter State");
            String state = Console.ReadLine();

            Console.WriteLine("Enter Phone Number");
            String phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Zip");
            String zip = Console.ReadLine();

            Contact contact = new Contact(firstName, lastName, address, city, state, phoneNumber, zip);
           
            
            foreach (Contact dc in list)
            {
                if (dc.PhoneNumber == phoneNumber)
                {
              
                    throw new DuplicateContactException("Duplicate Contact Found **** Please add valid Number");

                }

            }

            list.Add(contact);
            Console.WriteLine("Contact added successfully!");


        }

        public void EditContact()
        { 
            Console.WriteLine("Enter the name to update details : ");
            String editName = Console.ReadLine();

           foreach (Contact contact in list)
            {
                if (editName.Equals(contact.FirstName))
                {

                    Console.WriteLine("Enter the Number to edit particular option : ");
                    Console.WriteLine("Enter Numer \n 1 - First Name \n 2 - Last Name \n 3 - Adress \n 4 -  City \n 5 - State \n 6 - Phone Number \n 7 - Zip");
                    int no = int.Parse(Console.ReadLine());

                    if (no == 1)
                    {
                        Console.WriteLine("Enter  new First name ");
                        contact.FirstName = Console.ReadLine();
                    }

                    else if (no == 2)
                    {
                        Console.WriteLine("Enter  new Last name ");
                        contact.LastName = Console.ReadLine();
                    }

                    else if (no == 3)
                    {
                        Console.WriteLine("Enter  new Adress  ");
                        contact.Address = Console.ReadLine();
                    }

                    else if (no == 4)
                    {
                        Console.WriteLine("Enter new City ");
                        contact.City = Console.ReadLine();
                    }

                    else if (no == 5)
                    {
                        Console.WriteLine("Enter  new State ");
                        contact.State = Console.ReadLine();
                    }

                    else if (no == 6)
                    {
                        Console.WriteLine("Enter new Phone Number ");
                        contact.PhoneNumber = Console.ReadLine();
                    }

                    else if (no == 7)
                    {
                        Console.WriteLine("Enter new Zip ");
                        contact.Zip = Console.ReadLine();
                    }
                }
                else 
                {
                    throw new ContactNotFoundException("Contact Not Found **** please enter valid Name");
                }
                

            }
            Console.WriteLine("Contact edited successfully!");

        }

        public void DeleteContact()
        {
            Console.WriteLine("Enter the name to delete details : ");
            String deleteName = Console.ReadLine();

            foreach (Contact contact in list)          
            {
                
                if (deleteName == contact.FirstName)
                {
                    Console.WriteLine("Are you sure you want to DELETE this Contact?");
                    Console.WriteLine("1. YES\n2. NO");
                    int choose=int.Parse(Console.ReadLine());

                    if (choose == 1)
                    {
                        list.Remove(contact);
                        Console.WriteLine("Contact is Deleted!!");
                    }
                    else if(choose == 2) 
                    {
                        Console.WriteLine("Contact is Not Deleted !!");
                    }

                    else 
                    {
                        Console.WriteLine("You Entered InValid Number");
                    }
                }
                else
                {
                    throw new ContactNotFoundException("Contact Not Found **** please enter valid Name");
                }

            }

           
        }

        public void DisplayContact()
        { 
            Console.WriteLine("Enter the Name you want to display");
            String displayName = Console.ReadLine();
            
            foreach (Contact contact in list) 
            {
                if (displayName == contact.FirstName)
                {
                    Console.WriteLine($"Details of {contact.FirstName}");
                    Console.WriteLine($"First Name: {contact.FirstName}");
                    Console.WriteLine($"Last Name: {contact.LastName}");
                    Console.WriteLine($"Address: {contact.Address}");
                    Console.WriteLine($"City: {contact.City}");
                    Console.WriteLine($"State: {contact.State}");
                    Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
                    Console.WriteLine($"Zip: {contact.Zip}");
                }
                else 
                {
                    throw new ContactNotFoundException("Contact Not Found **** please enter valid Name");
                }

            }
        }
        public void Display()
        {

            foreach (Contact contact in list)
            {
                Console.WriteLine($"First Name: {contact.FirstName}");
                Console.WriteLine($"Last Name: {contact.LastName}");
                Console.WriteLine($"Address: {contact.Address}");
                Console.WriteLine($"City: {contact.City}");
                Console.WriteLine($"State: {contact.State}");
                Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
                Console.WriteLine($"Zip: {contact.Zip}");
            }
        }
    }
}
