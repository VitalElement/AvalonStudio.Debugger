using Newtonsoft.Json;
using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'setFunctionBreakpoints' request.
    /// Returned is information about each breakpoint created by this request.
    /// </summary>
    public class SetFunctionBreakpointsResponse : Response<SetFunctionBreakpointsResponseBody>
    {
    }

    public class SetFunctionBreakpointsResponseBody
    {
        /// <summary>
        /// Information about the breakpoints. 
        /// The array elements correspond to the elements of the 'breakpoints' array.
        /// </summary>
        [JsonProperty("breakpoints")]
        public IList<Breakpoint> Breakpoints { get; set; }
    }
}
