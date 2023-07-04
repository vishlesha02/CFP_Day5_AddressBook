using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ContactNotFoundException : Exception
    {
        public ContactNotFoundException(String message) : base(message)
        {

        }
    }
}
