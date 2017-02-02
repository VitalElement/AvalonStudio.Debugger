using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to Initialize request.
    /// </summary>
    public class RunInTerminalResponse : Response<RunInTerminalResponseBody>
    {
    }

    public class RunInTerminalResponseBody
    {
        /// <summary>
        /// The process ID.
        /// </summary>
        [JsonProperty("processId")]
        public int ProcessId { get; set; }
    }
}
