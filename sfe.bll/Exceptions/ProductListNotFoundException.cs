using System;
using System.Runtime.Serialization;

namespace sfe.bll
{
    [Serializable]
    internal class ProductListNotFoundException : Exception
    {
        public ProductListNotFoundException()
        {
        }

        public ProductListNotFoundException(string message) : base(message)
        {
        }

        public ProductListNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductListNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}