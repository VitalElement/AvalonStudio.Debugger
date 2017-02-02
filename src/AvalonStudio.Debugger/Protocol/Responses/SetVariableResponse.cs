using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'setVariable' request.
    /// </summary>
    public class SetVariableResponse : Response<SetVariableResponseBody>
    {
    }

    public class SetVariableResponseBody
    {
        /// <summary>
        /// The new value of the variable.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// The type of the new value. Typically shown in the UI when hovering over the value.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// If variablesReference is > 0, the new value is structured and its children can be retrieved by passing variablesReference to the VariablesRequest.
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
