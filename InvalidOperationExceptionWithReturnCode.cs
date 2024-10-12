using System;
using System.Runtime.Serialization;

namespace MyDevTime.ExceptionsWithReturnCode;

/// <summary>
/// Represents a custom exception that includes an additional return code.
/// This class extends the base <see cref="InvalidOperationException"/> class to include a return code, 
/// which can be used to provide more context or error codes related to the exception.
/// </summary>
public class InvalidOperationExceptionWithReturnCode : InvalidOperationException
{
    /// <summary>
    /// Gets the return code associated with this exception.
    /// </summary>
    public int ReturnCode { get; }

    public InvalidOperationExceptionWithReturnCode(int returnCode)
    {
        ReturnCode = returnCode;
    }

    [Obsolete("Obsolete")]
    protected InvalidOperationExceptionWithReturnCode(SerializationInfo info, StreamingContext context, int returnCode) : base(info, context)
    {
        ReturnCode = returnCode;
    }

    public InvalidOperationExceptionWithReturnCode(string message, int returnCode) : base(message)
    {
        ReturnCode = returnCode;
    }

    public InvalidOperationExceptionWithReturnCode(string message, Exception innerException, int returnCode) : base(message, innerException)
    {
        ReturnCode = returnCode;
    }
}