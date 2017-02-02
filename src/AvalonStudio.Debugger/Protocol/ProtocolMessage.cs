using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AvalonStudio.Debugger.Protocol
{
    public enum MessageType { Request, Response, Event }

    /// <summary>
    /// Base class of requests, responses, and events.
    /// </summary>
    public abstract class ProtocolMessage
    {
        /// <summary>
        /// Sequence number.
        /// </summary>
        [JsonProperty("seq")]
        public int Sequence { get; set; }

        /// <summary>
        /// One of 'request', 'response', or 'event'.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public abstract MessageType MessageType { get; }
    }
}
