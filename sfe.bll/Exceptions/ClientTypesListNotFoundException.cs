using System;
using System.Runtime.Serialization;

namespace sfe.bll.Exceptions
{
    [Serializable]
    internal class ClientTypesListNotFoundException : Exception
    {
        public ClientTypesListNotFoundException()
        {
        }

        public ClientTypesListNotFoundException(string message) : base(message)
        {
        }

        public ClientTypesListNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ClientTypesListNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}