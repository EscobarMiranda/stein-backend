using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class ChangePasswordException : Exception
    {
        public ChangePasswordException()
        {
        }

        public ChangePasswordException(string message) : base(message)
        {
        }

        public ChangePasswordException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ChangePasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}