using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// A client or server-initiated request.
    /// </summary>
    public abstract class Request<TArgs> : ProtocolMessage
    {
        /// <inheritdoc/>
        public override MessageType MessageType => MessageType.Request;

        /// <summary>
        /// The command to Execute
        /// </summary>
        [JsonProperty("command")]
        public abstract string Command { get; }
        
        /// <summary>
        /// Object containing arguments for the command.
        /// </summary>
        [JsonProperty("arguments")]
        public TArgs Arguments { get; set; }
    }
}
