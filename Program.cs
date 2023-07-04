using AddressBook;
using OopsConcept;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class Program 
    {
        public static void Main(String[] args)
        {

            AddressBook ab = new AddressBook();

            while (1 < 2)
            {
                Console.WriteLine("Enter Number  \n 1 - Add \n 2 - Edit \n 3 - Remove \n 4 - single Contact \n 5 - view \n 6 - Exit");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine();

                try
                {
                    if (num == 1)
                    {
                        ab.AddContacts();
                    }


                    else if (num == 2)
                    {
                        ab.EditContact();
                    }

                    else if (num == 3)
                    {
                        ab.DeleteContact();
                    }

                    else if (num == 4)
                    {
                        ab.DisplayContact();
                    }

                    else if (num == 5)
                    {
                        ab.Display();
                    }

                    else
                    {
                        break;

                    }
                }
                catch (DuplicateContactException ex)
                {
                    Console.WriteLine($"DuplicateContactException { ex.Message}");
                }
                catch(ContactNotFoundException e) 
                {
                    Console.WriteLine($"ContactNotFound {e.Message}");
                }
                Console.WriteLine();

            }

        }
       
    }
}