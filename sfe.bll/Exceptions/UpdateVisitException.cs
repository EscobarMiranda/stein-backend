using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class UpdateVisitException : Exception
    {
        public UpdateVisitException()
        {
        }

        public UpdateVisitException(string message) : base(message)
        {
        }

        public UpdateVisitException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UpdateVisitException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
