# ExceptionsWithReturnCode

`ExceptionsWithReturnCode` is a simple library that extends the standard exception handling in .NET by adding support for a return code (`int`). This allows developers to associate specific error codes with exceptions, making error handling more structured and informative.

## Features

- **Extend Default Exceptions**: Wrap standard exceptions or create custom exceptions with a return code.
- **Custom Return Codes**: Associate meaningful return codes (e.g., HTTP status codes, internal error codes) with exceptions.
- **Easy to Use**: Familiar exception handling pattern with added functionality for return codes.
- **Flexible and Lightweight**: Use in both small and large projects to improve error handling without added complexity.

## Installation

You can install the package via NuGet Package Manager or by using the .NET CLI:

### NuGet Package Manager:
```
Install-Package MyDevTime.ExceptionsWithReturnCode
```
### .NET CLI:
```
dotnet add package MyDevTime.ExceptionsWithReturnCode
```


## Usage

`ExceptionsWithReturnCode` introduces the `ExceptionWithReturnCode` class that extends the `Exception` class with an additional `ReturnCode` property. This makes it simple to throw exceptions with return codes and catch them where needed.

### Example Usage

```csharp
using MyDevTime.ExceptionsWithReturnCode;

public class MyService
{
    public void Process()
    {
        try
        {
            // Some logic that might throw an exception
            throw new ExceptionWithReturnCode("An error occurred", 500);
        }
        catch (ExceptionWithReturnCode ex)
        {
            Console.WriteLine($"Error: {ex.Message}, Return Code: {ex.ReturnCode}");
            // Handle error with return code
        }
    }
}
```
### Custom Exceptions
You can also create your own exceptions that inherit from `ExceptionWithReturnCode`.

using MyDevTime.ExceptionsWithReturnCode;
```csharp
public class MyCustomException : ExceptionWithReturnCode
{
    public MyCustomException(string message, int returnCode) : base(message, returnCode)
    {
    }
}
```

### Accessing the Return Code

```csharp
try
{
    // Some logic that might throw an exception
    throw new ExceptionWithReturnCode("Database error", 1001);
}
catch (ExceptionWithReturnCode ex)
{
    Console.WriteLine($"Caught exception with return code: {ex.ReturnCode}");
    // Log or handle the return code
}
```

## License
This project is licensed under the Apache License 2.0. See the [LICENSE](LICENSE.txt) file for details.

## Support
If you encounter any issues or have questions, feel free to open an issue on the GitHub repository.