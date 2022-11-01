using System.Runtime.Serialization;

namespace GenericsProgram
{
    [Serializable]
    internal class IndexNotAvailable : Exception
    {
        public IndexNotAvailable()
        {
        }

        public IndexNotAvailable(string? message) : base(message)
        {
        }

        public IndexNotAvailable(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected IndexNotAvailable(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}