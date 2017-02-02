namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// Restart request; value of command field is 'restart'.
    /// Restarts a debug session. If the capability 'supportsRestartRequest' is missing or has the value false,
    /// the client will implement 'restart' by terminating the debug adapter first and then launching it anew.
    /// A debug adapter can override this default behaviour by implementing a restart request
    /// and setting the capability 'supportsRestartRequest' to true.
    /// </summary>
    public class RestartRequest : Request<object>
    {
        private const string COMMAND = "restart";
        public override string Command => COMMAND;
    }
}
