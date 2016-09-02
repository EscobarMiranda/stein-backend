using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class QuestionListNotFoundException : Exception
    {
        public QuestionListNotFoundException()
        {
        }

        public QuestionListNotFoundException(string message) : base(message)
        {
        }

        public QuestionListNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected QuestionListNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}