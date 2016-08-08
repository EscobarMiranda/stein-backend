using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll.Exceptions
{
    public class PostVisitsException : Exception
    {
        public PostVisitsException()
        {
        }

        public PostVisitsException(string message)
            : base(message)
        {
        }

        public PostVisitsException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
