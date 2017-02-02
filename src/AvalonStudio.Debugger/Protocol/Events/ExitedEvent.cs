using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Events
{
    /// <summary>
    /// Event message for 'exited' event type.
    /// The event indicates that the debuggee has exited.
    /// </summary>
    public class ExitedEvent : DebuggerEvent<ExitedEventBody>
    {
        private const string EXITED = "exited";

        public override string Event => EXITED;
    }

    public class ExitedEventBody
    {
        /// <summary>
        /// The exit code returned from the debuggee.
        /// </summary>
        [JsonProperty("exitCode")]
        public int ExitCode { get; set; }
    }
}
