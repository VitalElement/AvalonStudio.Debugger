using Newtonsoft.Json;
using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'completions' request.
    /// </summary>
    public class CompletionsResponse : Response<CompletionsResponseBody>
    {
    }

    public class CompletionsResponseBody
    {
        /// <summary>
        /// The possible completions for .
        /// </summary>
        [JsonProperty("targets")]
        public IList<CompletionItem> Targets { get; set; }
    }
}
