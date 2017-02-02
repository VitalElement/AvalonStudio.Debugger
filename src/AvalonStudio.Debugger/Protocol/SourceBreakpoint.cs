using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// Properties of a breakpoint passed to the setBreakpoints request.
    /// </summary>
    public class SourceBreakpoint
    {
        /// <summary>
        /// The source line of the breakpoint.
        /// </summary>
        [JsonProperty("line")]
        public int Line { get; set; }

        /// <summary>
        /// An optional source column of the breakpoint.
        /// </summary>
        [JsonProperty("column")]
        public int Column { get; set; }

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
