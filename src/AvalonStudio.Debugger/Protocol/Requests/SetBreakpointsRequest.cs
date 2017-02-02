using Newtonsoft.Json;
using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// SetBreakpoints request; value of command field is 'setBreakpoints'.
    /// Sets multiple breakpoints for a single source and clears all previous breakpoints in that source.
    /// To clear all breakpoint for a source, specify an empty array.
    /// When a breakpoint is hit, a StoppedEvent (event type 'breakpoint') is generated.
    /// </summary>
    public class SetBreakpointsRequest : Request<SetBreakpointsArguments>
    {
        private const string COMMAND = "setBreakpoints";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'setBreakpoints' request.
    /// </summary>
    public class SetBreakpointsArguments
    {
        /// <summary>
        /// The source location of the breakpoints; either source.path or source.reference must be specified.
        /// </summary>
        [JsonProperty("source")]
        public Source Source { get; set; }

        /// <summary>
        /// The code locations of the breakpoints.
        /// </summary>
        [JsonProperty("breakpoints")]
        public IList<SourceBreakpoint> Breakpoints { get; set; }

        /// <summary>
        /// Deprecated: The code locations of the breakpoints.
        /// </summary>
        [JsonProperty("lines")]
        public IList<int> Lines { get; set; }

        /// <summary>
        /// A value of true indicates that the underlying source has been modified which results in new breakpoint locations.
        /// </summary>
        [JsonProperty("sourceModified")]
        public bool SourceModified { get; set; }
    }
}
