﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll.Exceptions
{
    public class ClientNotFoundException : Exception
    {
        public ClientNotFoundException()
        {
        }

        public ClientNotFoundException(string message)
            : base(message)
        {
        }

        public ClientNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
