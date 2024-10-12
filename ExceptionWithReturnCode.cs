using System;
using System.Runtime.Serialization;

namespace MyDevTime.ExceptionsWithReturnCode
{
    /// <summary>
    /// Represents a custom exception that includes an additional return code.
    /// This class extends the base <see cref="Exception"/> class to include a return code, 
    /// which can be used to provide more context or error codes related to the exception.
    /// </summary>
    public class ExceptionWithReturnCode : Exception
    {
        /// <summary>
        /// Gets the return code associated with this exception.
        /// </summary>
        public int ReturnCode { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionWithReturnCode"/> class
        /// with the specified return code.
        /// </summary>
        /// <param name="returnCode">The return code associated with this exception.</param>
        public ExceptionWithReturnCode(int returnCode)
        {
            ReturnCode = returnCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionWithReturnCode"/> class 
        /// with serialized data.
        /// </summary>
        /// <param name="info">The serialization information.</param>
        /// <param name="context">The streaming context.</param>
        /// <param name="returnCode">The return code associated with this exception.</param>
        [Obsolete("Obsolete")]
        protected ExceptionWithReturnCode(SerializationInfo info, StreamingContext context, int returnCode) 
            : base(info, context)
        {
            ReturnCode = returnCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionWithReturnCode"/> class
        /// with a specified error message and return code.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="returnCode">The return code associated with this exception.</param>
        public ExceptionWithReturnCode(string message, int returnCode) : base(message)
        {
            ReturnCode = returnCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionWithReturnCode"/> class
        /// with a specified error message, an inner exception, and return code.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        /// <param name="returnCode">The return code associated with this exception.</param>
        public ExceptionWithReturnCode(string message, Exception innerException, int returnCode) 
            : base(message, innerException)
        {
            ReturnCode = returnCode;
        }
    }
}