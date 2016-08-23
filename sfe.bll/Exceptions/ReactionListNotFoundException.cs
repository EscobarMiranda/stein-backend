using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class ReactionListNotFoundException : Exception
    {
        public ReactionListNotFoundException()
        {
        }

        public ReactionListNotFoundException(string message) : base(message)
        {
        }

        public ReactionListNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ReactionListNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
