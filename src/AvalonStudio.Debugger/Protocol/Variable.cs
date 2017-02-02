using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// A Variable is a name/value pair.
    /// Optionally a variable can have a 'type' that is shown if space permits or when hovering over the variable's name.
    /// An optional 'kind' is used to render additional properties of the variable, 
    /// e.g. different icons can be used to indicate that a variable is public or private.
    /// If the value is structured (has children), a handle is provided to retrieve the children with the VariablesRequest.
    /// If the number of named or indexed children is large, the numbers should be returned via the optional 'namedVariables' and 'indexedVariables' attributes.\nThe client can use this optional information to present the children in a paged UI and fetch them in chunks.
    /// </summary>
    public class Variable
    {
        /// <summary>
        /// The variable's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The variable's value. This can be a multi-line text, e.g. for a function the body of a function.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// The type of the variable's value. Typically shown in the UI when hovering over the value.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Properties of a variable that can be used to determine how to render the variable in the UI. Format of the string value: TBD.
        /// </summary>
        [JsonProperty("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Optional evaluatable name of this variable which can be passed to the 'EvaluateRequest' to fetch the variable's value.
        /// </summary>
        [JsonProperty("evaluateName")]
        public string EvaluateName { get; set; }

        /// <summary>
        /// If variablesReference is > 0, the variable is structured and its children can be retrieved by passing variablesReference to the VariablesRequest.
        /// </summary>
        [JsonProperty("variablesReference")]
        public int VariablesReference { get; set; }

        /// <summary>
        /// The number of named child variables.
        /// The client can use this optional information to present the children in a paged UI and fetch them in chunks.
        /// </summary>
        [JsonProperty("namedVariables")]
        public int NamedVariables { get; set; }

        /// <summary>
        /// The number of indexed child variables.
        /// The client can use this optional information to present the children in a paged UI and fetch them in chunks.
        /// </summary>
        [JsonProperty("indexedVariables")]
        public int IndexedVariables { get; set; }
    }
}
