using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class UpdateProductException : Exception
    {
        public UpdateProductException()
        {
        }

        public UpdateProductException(string message) : base(message)
        {
        }

        public UpdateProductException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UpdateProductException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
