using Newtonsoft.Json;
using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// SetExceptionBreakpoints request; value of command field is 'setExceptionBreakpoints'.
    /// The request configures the debuggers response to thrown exceptions. 
    /// If an execption is configured to break, a StoppedEvent is fired (event type 'exception').
    /// </summary>
    public class SetExceptionBreakpointsRequest : Request<SetExceptionBreakpointsArguments>
    {
        private const string COMMAND = "setExceptionBreakpoints";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'setExceptionBreakpoints' request.
    /// </summary>
    public class SetExceptionBreakpointsArguments
    {
        /// <summary>
        /// IDs of checked exception options. The set of IDs is returned via the 'exceptionBreakpointFilters' capability.
        /// </summary>
        [JsonProperty("filters")]
        public IList<string> Filters { get; set; }

        /// <summary>
        /// Configuration options for selected exceptions.
        /// </summary>
        [JsonProperty("exceptionOptions")]
        public IList<ExceptionOptions> ExceptionOptions { get; set; }
    }
}
