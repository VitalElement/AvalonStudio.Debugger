using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'evaluate' request.
    /// </summary>
    public class EvaluateResponse : Response<EvaluateResponseBody>
    {
    }

    public class EvaluateResponseBody
    {
        /// <summary>
        /// The result of the evaluate request.
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// The optional type of the evaluate result.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// If variablesReference is > 0, the evaluate result is structured and its children can be retrieved by passing variablesReference to the VariablesRequest.
        /// </summary>
        [JsonProperty("variablesReference")]
        public int VariablesReference { get; set; }

        /// <summary>
        /// The number of named child variables.
        /// The client can use this optional information to present the variables in a paged UI and fetch them in chunks.
        /// </summary>
        [JsonProperty("namedVariables")]
        public int NamedVariables { get; set; }

        /// <summary>
        /// The number of indexed child variables.
        /// The client can use this optional information to present the variables in a paged UI and fetch them in chunks.
        /// </summary>
        [JsonProperty("indexedVariables")]
        public int IndexedVariables { get; set; }
    }
}
