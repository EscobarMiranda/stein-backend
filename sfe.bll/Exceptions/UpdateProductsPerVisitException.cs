using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class UpdateProductsPerVisitException : Exception
    {
        public UpdateProductsPerVisitException()
        {
        }

        public UpdateProductsPerVisitException(string message) : base(message)
        {
        }

        public UpdateProductsPerVisitException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UpdateProductsPerVisitException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
