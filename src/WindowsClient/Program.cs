using HelloWorld.Core;

var diagnostics = new SimpleDiagnostics();
var manager = new ConnectionManager(diagnostics);

manager.StatusChanged += (_, status) =>
    Console.WriteLine($"[STATUS] {status.State} | {status.Message}");

manager.ErrorOccurred += (_, error) =>
    Console.WriteLine($"[ERROR] {error.Message}");

Console.WriteLine("WindowsClient demo started.");
Console.WriteLine("Commands: connect, disconnect, fail, status, exit");

while (true)
{
    Console.Write("> ");
    var command = Console.ReadLine()?.Trim().ToLowerInvariant();

    switch (command)
    {
        case "connect":
            await manager.ConnectAsync();
            break;
        case "disconnect":
            await manager.DisconnectAsync();
            break;
        case "fail":
            manager.ReportFailure(new Exception("Manual demo failure"));
            break;
        case "status":
            var status = manager.GetStatus();
            Console.WriteLine($"Current status: {status.State} | {status.Message}");
            break;
        case "exit":
            return;
        default:
            Console.WriteLine("Unknown command.");
            break;
    }
}
