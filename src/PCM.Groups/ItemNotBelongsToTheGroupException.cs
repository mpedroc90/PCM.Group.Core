using System;
using System.Runtime.Serialization;

namespace PCM.Groups
{
    /// <inheritdoc />
    /// <summary>
    /// The Item does not belongs to the group
    /// </summary>
    [Serializable]
    public class ItemNotBelongsToTheGroupException : InvalidOperationException
    {
        /// <inheritdoc />
        public ItemNotBelongsToTheGroupException()
        {
        }

        /// <inheritdoc />
        public ItemNotBelongsToTheGroupException(string message) : base(message)
        {
        }
        /// <inheritdoc />
        public ItemNotBelongsToTheGroupException(string message, Exception innerException) : base(message, innerException)
        {
        }
       
        /// <inheritdoc />
        protected ItemNotBelongsToTheGroupException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}