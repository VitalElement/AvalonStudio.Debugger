using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// Properties of a breakpoint passed to the setFunctionBreakpoints request.
    /// </summary>
    public class FunctionBreakpoint
    {
        /// <summary>
        /// The name of the function.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// An optional expression for conditional breakpoints.
        /// </summary>
        [JsonProperty("condition")]
        public string Condition { get; set; }

        /// <summary>
        /// An optional expression that controls how many hits of the breakpoint are ignored. 
        /// The backend is expected to interpret the expression as needed.
        /// </summary>
        [JsonProperty("hitCondition")]
        public string HitCondition { get; set; }
    }
}
