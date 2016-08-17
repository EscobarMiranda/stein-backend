using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class VisitNotFoundException : Exception
    {
        public VisitNotFoundException()
        {
        }

        public VisitNotFoundException(string message) : base(message)
        {
        }

        public VisitNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VisitNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
