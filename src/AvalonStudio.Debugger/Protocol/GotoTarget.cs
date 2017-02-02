using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// A GotoTarget describes a code location that can be used as a target in the 'goto' request.
    /// The possible goto targets can be determined via the 'gotoTargets' request.
    /// </summary>
    public class GotoTarget
    {
        /// <summary>
        /// Unique identifier for a goto target. This is used in the goto request.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the goto target (shown in the UI).
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// The line of the goto target.
        /// </summary>
        [JsonProperty("line")]
        public int Line { get; set; }

        /// <summary>
        /// An optional column of the goto target.
        /// </summary>
        [JsonProperty("column")]
        public int Column { get; set; }

        /// <summary>
        /// An optional end line of the range covered by the goto target.
        /// </summary>
        [JsonProperty("endLine")]
        public int EndLine { get; set; }

        /// <summary>
        /// An optional end column of the range covered by the goto target.
        /// </summary>
        [JsonProperty("endColumn")]
        public int EndColumn { get; set; }
    }
}
