namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// Thread request; value of command field is 'threads'.
    /// The request retrieves a list of all threads.
    /// </summary>
    public class ThreadsRequest : Request<object>
    {
        private const string COMMAND = "threads";
        public override string Command => COMMAND;
    }
}
