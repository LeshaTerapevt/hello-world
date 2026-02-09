namespace HelloWorld.Core;

public interface IConnectionManager
{
    event EventHandler<ConnectionStatus>? StatusChanged;
    event EventHandler<Exception>? ErrorOccurred;

    ConnectionStatus GetStatus();
    Task ConnectAsync(CancellationToken cancellationToken = default);
    Task DisconnectAsync(CancellationToken cancellationToken = default);
}
