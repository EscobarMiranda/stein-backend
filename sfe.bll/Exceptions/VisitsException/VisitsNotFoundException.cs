using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll.Exceptions
{
    public class VisitsNotFoundException : Exception
    {
        public VisitsNotFoundException()
        {
        }

        public VisitsNotFoundException(string message)
            : base(message)
        {
        }

        public VisitsNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
