namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// ConfigurationDone request; value of command field is 'configurationDone'.
    /// The client of the debug protocol must send this request at the end of the sequence of configuration requests (which was started by the InitializedEvent).
    /// The configurationDone request has no standardized attributes.
    /// </summary>
    public class ConfigurationDoneRequest : Request<object>
    {
        private const string COMMAND = "configurationDone";
        public override string Command => COMMAND;
    }
}
