using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class UpdateClientException : Exception
    {
        public UpdateClientException()
        {
        }

        public UpdateClientException(string message) : base(message)
        {
        }

        public UpdateClientException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UpdateClientException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
