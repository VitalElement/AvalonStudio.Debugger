using Newtonsoft.Json;
using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'stackTrace' request.
    /// </summary>
    public class StackTraceResponse : Response<StackTraceResponseBody>
    {
    }

    public class StackTraceResponseBody
    {
        /// <summary>
        /// The frames of the stackframe. If the array has length zero, there are no stackframes available.
        /// This means that there is no location information available.
        /// </summary>
        [JsonProperty("stackFrames")]
        public IList<StackFrame> StackFrames { get; set; }

        /// <summary>
        /// The total number of frames available.
        /// </summary>
        [JsonProperty("totalFrames")]
        public int TotalFrames { get; set; }
    }
}
