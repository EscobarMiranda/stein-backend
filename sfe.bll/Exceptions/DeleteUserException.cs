using System;
using System.Runtime.Serialization;

namespace sfe.bll
{
    [Serializable]
    internal class DeleteUserException : Exception
    {
        public DeleteUserException()
        {
        }

        public DeleteUserException(string message) : base(message)
        {
        }

        public DeleteUserException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DeleteUserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}