using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AvalonStudio.Debugger.Protocol.Events
{
    /// <summary>
    /// Event message for 'thread' event type.
    /// The event indicates that a thread has started or exited.
    /// </summary>
    public class ThreadEvent : DebuggerEvent<ThreadEventBody>
    {
        private const string THREAD = "thread";

        public override string Event => THREAD;
    }

    public class ThreadEventBody
    {
        /// <summary>
        /// The identifier of the thread.
        /// </summary>
        [JsonProperty("threadId")]
        public string ThreadId { get; set; }

        /// <summary>
        /// The reason for the event (such as: 'started', 'exited').
        /// </summary>
        [JsonProperty("reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ThreadEventReason Reason { get; set; }
    }

    public enum ThreadEventReason { Started, Exited }
}
