namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// Attach request; value of command field is 'attach'.
    /// </summary>
    public class AttachRequest : Request<object>
    {
        private const string COMMAND = "attach";
        public override string Command => COMMAND;
    }
}
