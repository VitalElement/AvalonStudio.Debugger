using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'continue' request.
    /// </summary>
    public class ContinueResponse : Response<ContinueResponseBody>
    {
    }

    public class ContinueResponseBody
    {
        /// <summary>
        /// If true, the continue request has ignored the specified thread and continued all threads instead. 
        /// If this attribute is missing a value of 'true' is assumed for backward compatibility.
        /// </summary>
        [JsonProperty("allThreadsContinued")]
        public bool AllThreadsContinued { get; set; } = true;
    }
}
