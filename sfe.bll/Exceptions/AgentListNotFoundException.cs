using System;
using System.Runtime.Serialization;

namespace sfe.bll
{
    [Serializable]
    internal class AgentListNotFoundException : Exception
    {
        public AgentListNotFoundException()
        {
        }

        public AgentListNotFoundException(string message) : base(message)
        {
        }

        public AgentListNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AgentListNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}