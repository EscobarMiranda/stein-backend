using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class PostQuestionOptionsException : Exception
    {
        public PostQuestionOptionsException()
        {
        }

        public PostQuestionOptionsException(string message) : base(message)
        {
        }

        public PostQuestionOptionsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PostQuestionOptionsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}