using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// Information about a Breakpoint created in setBreakpoints or setFunctionBreakpoints.
    /// </summary>
    public class Breakpoint
    {
        /// <summary>
        /// An optional unique identifier for the breakpoint.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// If true breakpoint could be set (but not necessarily at the desired location).
        /// </summary>
        [JsonProperty("verified")]
        public bool Verified { get; set; }

        /// <summary>
        /// An optional message about the state of the breakpoint. This is shown to the user and can be used to explain why a breakpoint could not be verified.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// The source where the breakpoint is located.
        /// </summary>
        [JsonProperty("source")]
        public Source Source { get; set; }

        /// <summary>
        /// The start line of the actual range covered by the breakpoint.
        /// </summary>
        [JsonProperty("line")]
        public int Line { get; set; }

        /// <summary>
        /// An optional start column of the actual range covered by the breakpoint.
        /// </summary>
        [JsonProperty("column")]
        public int Column { get; set; }

        /// <summary>
        /// An optional end line of the actual range covered by the breakpoint.
        /// </summary>
        [JsonProperty("endLine")]
        public int EndLine { get; set; }

        /// <summary>
        /// An optional end column of the actual range covered by the breakpoint. 
        /// If no end line is given, then the end column is assumed to be in the start line.
        /// </summary>
        [JsonProperty("endColumn")]
        public int EndColumn { get; set; }
    }
}
