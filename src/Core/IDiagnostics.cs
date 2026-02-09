namespace HelloWorld.Core;

public interface IDiagnostics
{
    void LogInfo(string message);
    void LogWarning(string message);
    void LogError(string message, Exception? exception = null);
}
