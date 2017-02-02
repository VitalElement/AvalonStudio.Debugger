using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// On error that is whenever 'success' is false, the body can provide more details.
    /// </summary>
    public class ErrorResponse : Response<ErrorResponseBody>
    {
    }

    public class ErrorResponseBody
    {
        /// <summary>
        /// An optional, structured error message.
        /// </summary>
        [JsonProperty("error")]
        public Message Error { get; set; }
    }    
}
