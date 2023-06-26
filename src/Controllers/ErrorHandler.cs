public class ErrorHandler : Exception
{
    private string _message;
    private int _errorCode;

    public ErrorHandler(string message, int errorCode)
    {
        _message = message;
        _errorCode = errorCode;
    }
    public static ErrorHandler HandleInputError(string? message)
    {
        return new ErrorHandler(message ?? "Invalid input", 500);
    }

    public static ErrorHandler HandleNotFoundError(string? message)
    {
        return new ErrorHandler(message ?? "Resource not found", 404);
    }

    public override string ToString()
    {
        return $"Error code: {_errorCode} \nMessage: {_message}";
    }


}