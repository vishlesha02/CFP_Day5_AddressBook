using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Contact
    {
       public String FirstName;
       public String LastName;
       public String Address;
       public String City;
       public String State;
       public String PhoneNumber;
       public String Zip;

        public Contact(string firstName, string lastName, string address, string state, string city, string phoneNumber, string zip)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.PhoneNumber = phoneNumber;
            this.Zip = zip;
        }
       
    }

}
