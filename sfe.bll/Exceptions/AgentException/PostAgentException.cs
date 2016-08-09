using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll.Exceptions
{
    public class PostAgentException : Exception
    {
        public PostAgentException()
        {
        }

        public PostAgentException(string message)
            : base(message)
        {
        }

        public PostAgentException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
