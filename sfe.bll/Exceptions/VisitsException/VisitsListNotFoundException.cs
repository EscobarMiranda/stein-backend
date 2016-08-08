using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll.Exceptions
{
    public class VisitsListNotFoundException : Exception
    {
        public VisitsListNotFoundException()
        {
        }

        public VisitsListNotFoundException(string message)
            : base(message)
        {
        }

        public VisitsListNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
