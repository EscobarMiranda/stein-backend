using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class DeleteClientException : Exception
    {
        public DeleteClientException()
        {
        }

        public DeleteClientException(string message) : base(message)
        {
        }

        public DeleteClientException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DeleteClientException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
