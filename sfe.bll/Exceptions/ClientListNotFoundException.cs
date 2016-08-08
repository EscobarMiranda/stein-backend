using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll.Exceptions
{
    public class ClientListNotFoundException : Exception
    {
        public ClientListNotFoundException()
        {
        }

        public ClientListNotFoundException(string message)
            : base(message)
        {
        }

        public ClientListNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
