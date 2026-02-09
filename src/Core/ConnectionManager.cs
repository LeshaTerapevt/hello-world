namespace HelloWorld.Core;

public sealed class ConnectionManager : IConnectionManager
{
    private readonly IDiagnostics _diagnostics;
    private ConnectionStatus _status = new(ConnectionState.Idle);

    public ConnectionManager(IDiagnostics diagnostics)
    {
        _diagnostics = diagnostics;
    }

    public event EventHandler<ConnectionStatus>? StatusChanged;
    public event EventHandler<Exception>? ErrorOccurred;

    public ConnectionStatus GetStatus() => _status;

    public Task ConnectAsync(CancellationToken cancellationToken = default)
    {
        UpdateStatus(ConnectionState.Connecting, "Connecting");
        UpdateStatus(ConnectionState.Connected, "Connected");
        return Task.CompletedTask;
    }

    public Task DisconnectAsync(CancellationToken cancellationToken = default)
    {
        UpdateStatus(ConnectionState.Idle, "Disconnected");
        return Task.CompletedTask;
    }

    public void ReportFailure(Exception exception)
    {
        _diagnostics.LogError("Connection failed", exception);
        ErrorOccurred?.Invoke(this, exception);
        UpdateStatus(ConnectionState.Failed, exception.Message);
    }

    private void UpdateStatus(ConnectionState state, string? message = null)
    {
        _status = new ConnectionStatus(state, message);
        StatusChanged?.Invoke(this, _status);
        _diagnostics.LogInfo($"State={state}, Message={message}");
    }
}
