using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class PostProductsPerVisitException : Exception
    {
        public PostProductsPerVisitException()
        {
        }

        public PostProductsPerVisitException(string message) : base(message)
        {
        }

        public PostProductsPerVisitException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PostProductsPerVisitException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
