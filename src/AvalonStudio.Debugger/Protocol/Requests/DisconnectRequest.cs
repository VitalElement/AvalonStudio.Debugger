namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// Disconnect request; value of command field is 'disconnect'.
    /// </summary>
    public class DisconnectRequest : Request<object>
    {
        private const string COMMAND = "disconnect";
        public override string Command => COMMAND;
    }
}
