using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll.Exceptions
{
    public class PostClienException : Exception
    {
        public PostClienException()
        {
        }

        public PostClienException(string message)
            : base(message)
        {
        }

        public PostClienException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
