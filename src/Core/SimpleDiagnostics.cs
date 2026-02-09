namespace HelloWorld.Core;

public sealed class SimpleDiagnostics : IDiagnostics
{
    public void LogInfo(string message) => Console.WriteLine($"INFO: {message}");

    public void LogWarning(string message) => Console.WriteLine($"WARN: {message}");

    public void LogError(string message, Exception? exception = null)
    {
        Console.WriteLine($"ERROR: {message}");
        if (exception is not null)
        {
            Console.WriteLine(exception);
        }
    }
}
