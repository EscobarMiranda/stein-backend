using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class PostAnswersException : Exception
    {
        public PostAnswersException()
        {
        }

        public PostAnswersException(string message) : base(message)
        {
        }

        public PostAnswersException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PostAnswersException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}