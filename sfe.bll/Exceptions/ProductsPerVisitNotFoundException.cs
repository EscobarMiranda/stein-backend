using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class ProductsPerVisitNotFoundException : Exception
    {
        public ProductsPerVisitNotFoundException()
        {
        }

        public ProductsPerVisitNotFoundException(string message) : base(message)
        {
        }

        public ProductsPerVisitNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductsPerVisitNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
