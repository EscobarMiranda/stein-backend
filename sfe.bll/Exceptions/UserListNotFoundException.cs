using System;
using System.Runtime.Serialization;

namespace sfe.bll
{
    [Serializable]
    internal class UserListNotFoundException : Exception
    {
        public UserListNotFoundException()
        {
        }

        public UserListNotFoundException(string message) : base(message)
        {
        }

        public UserListNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserListNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}