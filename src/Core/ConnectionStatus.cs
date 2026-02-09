namespace HelloWorld.Core;

public sealed record ConnectionStatus(ConnectionState State, string? Message = null);
