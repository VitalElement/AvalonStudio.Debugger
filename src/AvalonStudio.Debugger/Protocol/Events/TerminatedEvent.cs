using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Events
{
    /// <summary>
    /// Event message for 'terminated' event types.
    /// The event indicates that debugging of the debuggee has terminated.
    /// </summary>
    public class TerminatedEvent : DebuggerEvent<TerminatedEventBody>
    {
        private const string TERMINATED = "terminated";

        public override string Event => TERMINATED;
    }

    public class TerminatedEventBody
    {
        /// <summary>
        /// A debug adapter may set 'restart' to true to request that the front end restarts the session.
        /// </summary>
        [JsonProperty("restart")]
        public bool Restart { get; set; }
    }
}
