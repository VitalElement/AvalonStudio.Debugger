using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// A Stackframe contains the source location.
    /// </summary>
    public class StackFrame
    {
        /// <summary>
        /// An identifier for the stack frame. 
        /// It must be unique across all threads. 
        /// This id can be used to retrieve the scopes of the frame with the 'scopesRequest' or to restart the execution of a stackframe.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the stack frame, typically a method name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The optional source of the frame.
        /// </summary>
        [JsonProperty("source")]
        public Source Source { get; set; }

        /// <summary>
        /// The line within the file of the frame. If source is null or doesn't exist, line is 0 and must be ignored.
        /// </summary>
        [JsonProperty("line")]
        public int Line { get; set; }

        /// <summary>
        /// The column within the line. If source is null or doesn't exist, column is 0 and must be ignored.
        /// </summary>
        [JsonProperty("column")]
        public int Column { get; set; }

        /// <summary>
        /// An optional end line of the range covered by the stack frame.
        /// </summary>
        [JsonProperty("endLine")]
        public int EndLine { get; set; }

        /// <summary>
        /// An optional end column of the range covered by the stack frame.
        /// </summary>
        [JsonProperty("endColumn")]
        public int EndColumn { get; set; }

        /// <summary>
        /// The module associated with this frame, if any.
        /// </summary>
        [JsonProperty("moduleId")]
        public string ModuleId { get; set; }
    }
}
