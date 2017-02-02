using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to a request.
    /// </summary>
    public abstract class Response<TBody> : ProtocolMessage
    {
        /// <inheritdoc/>
        public override MessageType MessageType => MessageType.Response;

        /// <summary>
        /// Sequence number of the corresponding request.
        /// </summary>
        [JsonProperty("request_seq")]
        public int RequestSequence { get; set; }

        /// <summary>
        /// Outcome of the request.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// The command requested.
        /// </summary>
        [JsonProperty("command")]
        public string Command { get; set; }

        /// <summary>
        /// Contains error message if success == false.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Contains request result if success is true and optional error details if success is false.
        /// </summary>
        [JsonProperty("body")]
        public TBody Body { get; set; }
    }
}
