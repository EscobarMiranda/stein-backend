using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class PostUserException : Exception
    {
        public PostUserException()
        {
        }

        public PostUserException(string message) : base(message)
        {
        }

        public PostUserException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PostUserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
