using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class DuplicateContactException : Exception
    {
        public DuplicateContactException(String message) : base (message)
        {
        
        }
    }
}
