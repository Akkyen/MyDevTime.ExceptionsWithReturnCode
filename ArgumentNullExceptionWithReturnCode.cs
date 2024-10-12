using System;
using System.Runtime.Serialization;

namespace MyDevTime.ExceptionsWithReturnCode;

/// <summary>
/// Represents a custom exception that includes an additional return code.
/// This class extends the base <see cref="ArgumentNullException"/> class to include a return code, 
/// which can be used to provide more context or error codes related to the exception.
/// </summary>
public class ArgumentNullExceptionWithReturnCode : ArgumentNullException
{
    /// <summary>
    /// Gets the return code associated with this exception.
    /// </summary>
    public int ReturnCode { get; }

    public ArgumentNullExceptionWithReturnCode(int returnCode)
    {
        ReturnCode = returnCode;
    }

    [Obsolete("Obsolete")]
    protected ArgumentNullExceptionWithReturnCode(SerializationInfo info, StreamingContext context, int returnCode) : base(info, context)
    {
        ReturnCode = returnCode;
    }

    public ArgumentNullExceptionWithReturnCode(string paramName, int returnCode) : base(paramName)
    {
        ReturnCode = returnCode;
    }

    public ArgumentNullExceptionWithReturnCode(string message, Exception innerException, int returnCode) : base(message, innerException)
    {
        ReturnCode = returnCode;
    }

    public ArgumentNullExceptionWithReturnCode(string paramName, string message, int returnCode) : base(paramName, message)
    {
        ReturnCode = returnCode;
    }
}