using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// Provides formatting information for a stack frame.
    /// </summary>
    public class StackFrameFormat : ValueFormat
    {
        /// <summary>
        /// Displays parameters for the stack frame.
        /// </summary>
        [JsonProperty("parameters")]
        public bool Parameters { get; set; }

        /// <summary>
        /// Displays the types of parameters for the stack frame.
        /// </summary>
        [JsonProperty("parameterTypes")]
        public bool ParameterTypes { get; set; }

        /// <summary>
        /// Displays the names of parameters for the stack frame.
        /// </summary>
        [JsonProperty("parameterNames")]
        public bool ParameterNames { get; set; }

        /// <summary>
        /// Displays the values of parameters for the stack frame.
        /// </summary>
        [JsonProperty("parameterValues")]
        public bool ParameterValues { get; set; }

        /// <summary>
        /// Displays the line number of the stack frame.
        /// </summary>
        [JsonProperty("line")]
        public bool Line { get; set; }

        /// <summary>
        /// Displays the module of the stack frame.
        /// </summary>
        [JsonProperty("module")]
        public bool Module { get; set; }
    }
}
