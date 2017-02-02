using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'source' request.
    /// </summary>
    public class SourceResponse : Response<SourceResponseBody>
    {
    }

    public class SourceResponseBody
    {
        /// <summary>
        /// Content of the source reference.
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// Optional content type (mime type) of the source.
        /// </summary>
        [JsonProperty("mimeType")]
        public string MimeType { get; set; }
    }
}
