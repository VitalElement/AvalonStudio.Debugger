using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Events
{
    /// <summary>
    /// Event message for 'continued' event type.
    /// The event indicates that the execution of the debuggee has continued.
    /// Please note: a debug adapter is not expected to send this event in response to a request that implies that execution continues, e.g. 'launch' or 'continue'.
    /// It is only necessary to send a ContinuedEvent if there was no previous request that implied this.
    /// </summary>
    public class ContinuedEvent : DebuggerEvent<ContinuedEventBody>
    {
        private const string CONTINUED = "continued";

        public override string Event => CONTINUED;
    }

    public class ContinuedEventBody
    {
        /// <summary>
        /// The thread which was continued.
        /// </summary>
        [JsonProperty("threadId")]
        public int ThreadId { get; set; }

        /// <summary>
        /// Additional information. E.g. if reason is 'exception', text contains the exception name. 
        /// This string is shown in the UI.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// If allThreadsContinued is true, a debug adapter can announce that all threads have continued.
        /// </summary>
        [JsonProperty("allThreadsContinued")]
        public bool AllThreadsContinued { get; set; }
    }
}
