using System;
using System.Runtime.Serialization;

namespace sfe.bll
{
    [Serializable]
    internal class DeleteAgentException : Exception
    {
        public DeleteAgentException()
        {
        }

        public DeleteAgentException(string message) : base(message)
        {
        }

        public DeleteAgentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DeleteAgentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}