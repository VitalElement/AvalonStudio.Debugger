using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Events
{
    /// <summary>
    /// Server-initiated event.
    /// </summary>
    public abstract class DebuggerEvent<TBody> : ProtocolMessage
    {
        /// <inheritdoc/>
        public override MessageType MessageType => MessageType.Event;

        /// <summary>
        /// Type of event.
        /// </summary>
        [JsonProperty("event")]
        public abstract string Event { get; }

        /// <summary>
        /// Event-specific information.
        /// </summary>
        [JsonProperty("body")]
        public TBody Body { get; set; }
    }
}
