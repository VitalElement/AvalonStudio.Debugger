using Newtonsoft.Json;
using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// SetFunctionBreakpoints request; value of command field is 'setFunctionBreakpoints'.
    /// Sets multiple function breakpoints and clears all previous function breakpoints.
    /// To clear all function breakpoint, specify an empty array.
    /// When a function breakpoint is hit, a StoppedEvent (event type 'function breakpoint') is generated.
    /// </summary>
    public class SetFunctionBreakpointsRequest : Request<SetFunctionBreakpointsArguments>
    {
        private const string COMMAND = "setFunctionBreakpoints";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'setFunctionBreakpoints' request.
    /// </summary>
    public class SetFunctionBreakpointsArguments
    {
        /// <summary>
        /// The function names of the breakpoints.
        /// </summary>
        [JsonProperty("breakpoints")]
        public IList<FunctionBreakpoint> Breakpoints { get; set; }
    }
}
