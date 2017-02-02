using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AvalonStudio.Debugger.Protocol.Events
{
    public class StoppedEvent : DebuggerEvent<StoppedEventBody>
    {
        private const string STOPPED = "stopped";

        public override string Event => STOPPED;
    }

    public class StoppedEventBody
    {
        /// <summary>
        /// The reason for the event (such as: 'step', 'breakpoint', 'exception', 'pause'). 
        /// This string is shown in the UI.
        /// </summary>
        [JsonProperty("reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public StoppedEventReason Reason { get; set; }

        /// <summary>
        /// The thread which was stopped.
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
        /// If allThreadsStopped is true, a debug adapter can announce that all threads have stopped.
        /// *  The client should use this information to enable that all threads can be expanded to access their stacktraces.
        /// *  If the attribute is missing or false, only the thread with the given threadId can be expanded.
        /// </summary>
        [JsonProperty("allThreadsStopped")]
        public bool AllThreadsStopped { get; set; }
    }

    public enum StoppedEventReason { Step, Breakpoint, Exception, Pause }
}
