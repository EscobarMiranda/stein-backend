using System;
using System.Runtime.Serialization;

namespace sfe.bll
{
    [Serializable]
    internal class DeleteClienException : Exception
    {
        public DeleteClienException()
        {
        }

        public DeleteClienException(string message) : base(message)
        {
        }

        public DeleteClienException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DeleteClienException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}