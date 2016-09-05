using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class AnswerListNotFoundException : Exception
    {
        public AnswerListNotFoundException()
        {
        }

        public AnswerListNotFoundException(string message) : base(message)
        {
        }

        public AnswerListNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AnswerListNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}