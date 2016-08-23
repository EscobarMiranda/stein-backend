using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class VisitListNotFoundException : Exception
    {
        public VisitListNotFoundException()
        {
        }

        public VisitListNotFoundException(string message) : base(message)
        {
        }

        public VisitListNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VisitListNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
