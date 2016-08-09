using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll.Exceptions
{
    public class AgentListNotFoundException : Exception
    {
        public AgentListNotFoundException()
        {
        }

        public AgentListNotFoundException(string message)
            : base(message)
        {
        }

        public AgentListNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
