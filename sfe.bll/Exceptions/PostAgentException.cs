using System;
using System.Runtime.Serialization;

namespace sfe.bll
{
    [Serializable]
    internal class PostAgentException : Exception
    {
        public PostAgentException()
        {
        }

        public PostAgentException(string message) : base(message)
        {
        }

        public PostAgentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PostAgentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}