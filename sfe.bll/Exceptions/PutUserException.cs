using System;
using System.Runtime.Serialization;

namespace sfe.bll
{
    [Serializable]
    internal class PutUserException : Exception
    {
        public PutUserException()
        {
        }

        public PutUserException(string message) : base(message)
        {
        }

        public PutUserException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PutUserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}