using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AvalonStudio.Debugger.Protocol.Events
{
    public class BreakpointEvent : DebuggerEvent<BreakpointEventBody>
    {
        private const string BREAKPOINT = "breakpoint";

        public override string Event => BREAKPOINT;
    }

    public class BreakpointEventBody
    {
        /// <summary>
        /// The reason for the event (such as: 'changed', 'new').
        /// </summary>
        [JsonProperty("reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BreakpointEventReason Reason { get; set; }

        /// <summary>
        /// The breakpoint.
        /// </summary>
        [JsonProperty("breakpoint")]
        public Breakpoint Breakpoint { get; set; }
    }

    public enum BreakpointEventReason { Changed, New }
}
