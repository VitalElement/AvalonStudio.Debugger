using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// Initialize request; value of command field is 'initialize'
    /// </summary>
    public class InitializeRequest : Request<InitializeRequestArguments>
    {
        private const string COMMAND = "initialize";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'initialize' request.
    /// </summary>
    public class InitializeRequestArguments
    {
        /// <summary>
        /// The ID of the debugger adapter. Used to select or verify debugger adapter.
        /// </summary>
        [JsonProperty("adapterID")]
        public string AdapterId { get; set; }

        /// <summary>
        /// If true all line numbers are 1-based (default).
        /// </summary>
        [JsonProperty("linesStartAt1")]
        public bool LinesStartAt1 { get; set; } = true;

        /// <summary>
        /// If true all column numbers are 1-based (default).
        /// </summary>
        [JsonProperty("columnsStartAt1")]
        public bool ColumnsStartAt1 { get; set; } = true;

        /// <summary>
        /// Determines in what format paths are specified. 
        /// Possible values are 'path' or 'uri'. 
        /// The default is 'path', which is the native format.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("pathFormat")]
        public PathFormat PathFormat { get; set; }

        /// <summary>
        /// Client supports the optional type attribute for variables.
        /// </summary>
        [JsonProperty("supportsVariableType")]
        public bool SupportsVariableType { get; set; }

        /// <summary>
        /// Client supports the paging of variables.
        /// </summary>
        [JsonProperty("supportsVariablePaging")]
        public bool SupportsVariablePaging { get; set; }

        /// <summary>
        /// Client supports the runInTerminal request.
        /// </summary>
        [JsonProperty("supportsRunInTerminalRequest")]
        public bool SupportsRunInTerminalRequest { get; set; }
    }

    public enum PathFormat { Path, Uri }
}
