using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class PostVisitException : Exception
    {
        public PostVisitException()
        {
        }

        public PostVisitException(string message) : base(message)
        {
        }

        public PostVisitException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PostVisitException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
