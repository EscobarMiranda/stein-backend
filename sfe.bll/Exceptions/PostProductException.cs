using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class PostProductException : Exception
    {
        public PostProductException()
        {
        }

        public PostProductException(string message) : base(message)
        {
        }

        public PostProductException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PostProductException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
