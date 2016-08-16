using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class PostClientException : Exception
    {
        public PostClientException()
        {
        }

        public PostClientException(string message) : base(message)
        {
        }

        public PostClientException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PostClientException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
