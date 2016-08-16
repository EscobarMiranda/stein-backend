using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class ProductsPerVisitListNotFoundException : Exception
    {
        public ProductsPerVisitListNotFoundException()
        {
        }

        public ProductsPerVisitListNotFoundException(string message) : base(message)
        {
        }

        public ProductsPerVisitListNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductsPerVisitListNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
