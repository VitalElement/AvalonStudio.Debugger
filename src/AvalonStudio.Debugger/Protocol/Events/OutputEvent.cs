using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AvalonStudio.Debugger.Protocol.Events
{
    /// <summary>
    /// Event message for 'output' event type.
    /// The event indicates that the target has produced some output.
    /// </summary>
    public class OutputEvent : DebuggerEvent<OutputEventBody>
    {
        private const string OUTPUT = "output";

        public override string Event => OUTPUT;
    }

    public class OutputEventBody
    {
        /// <summary>
        /// The category of output (such as: 'console', 'stdout', 'stderr', 'telemetry'). 
        /// If not specified, 'console' is assumed.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("category")]
        public OutputEventCategory Category { get; set; }

        /// <summary>
        /// The output to report.
        /// </summary>
        [JsonProperty("output")]
        public string Output { get; set; }

        /// <summary>
        /// If an attribute 'variablesReference' exists and its value is > 0, the output contains objects which can be retrieved by passing variablesReference to the VariablesRequest.
        /// </summary>
        [JsonProperty("variablesReference")]
        public int VariablesReference { get; set; }

        /// <summary>
        /// Optional data to report. For the 'telemetry' category the data will be sent to telemetry, for the other categories the data is shown in JSON format.
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; set; }
    }

    public enum OutputEventCategory { Console, StdOut, StdErr, Telemetry }
}
