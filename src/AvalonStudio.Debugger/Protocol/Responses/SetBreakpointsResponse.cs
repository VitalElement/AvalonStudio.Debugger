using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'setBreakpoints' request.
    /// Returned is information about each breakpoint created by this request.
    /// This includes the actual code location and whether the breakpoint could be verified.
    /// The breakpoints returned are in the same order as the elements of the 'breakpoints'
    /// (or the deprecated 'lines') in the SetBreakpointsArguments.
    /// </summary>
    public class SetBreakpointsResponse : Response<SetBreakpointsResponseBody>
    {
    }

    public class SetBreakpointsResponseBody
    {
        /// <summary>
        /// Information about the breakpoints. 
        /// The array elements are in the same order as the elements of the 'breakpoints' (or the deprecated 'lines') in the SetBreakpointsArguments.
        /// </summary>
        public IList<Breakpoint> Breakpoints { get; set; }
    }
}
