using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// A Scope is a named container for variables. Optionally a scope can map to a source or a range within a source.
    /// </summary>
    public class Scope
    {
        /// <summary>
        /// Name of the scope such as 'Arguments', 'Locals'.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The variables of this scope can be retrieved by passing the value of variablesReference to the VariablesRequest.
        /// </summary>
        [JsonProperty("variablesReference")]
        public int VariablesReference { get; set; }

        /// <summary>
        /// The number of named variables in this scope.
        /// The client can use this optional information to present the variables in a paged UI and fetch them in chunks.
        /// </summary>
        [JsonProperty("namedVariables")]
        public int NamedVariables { get; set; }

        /// <summary>
        /// The number of indexed variables in this scope.
        /// The client can use this optional information to present the variables in a paged UI and fetch them in chunks.
        /// </summary>
        [JsonProperty("indexedVariables")]
        public int IndexedVariables { get; set; }

        /// <summary>
        /// If true, the number of variables in this scope is large or expensive to retrieve.
        /// </summary>
        [JsonProperty("expensive")]
        public bool Expensive { get; set; }

        /// <summary>
        /// Optional source for this scope.
        /// </summary>
        [JsonProperty("source")]
        public Source Source { get; set; }

        /// <summary>
        /// Optional start line of the range covered by this scope.
        /// </summary>
        [JsonProperty("line")]
        public int Line { get; set; }

        /// <summary>
        /// Optional start column of the range covered by this scope.
        /// </summary>
        [JsonProperty("column")]
        public int Column { get; set; }

        /// <summary>
        /// Optional end line of the range covered by this scope.
        /// </summary>
        [JsonProperty("endLine")]
        public int EndLine { get; set; }

        /// <summary>
        /// Optional end column of the range covered by this scope.
        /// </summary>
        [JsonProperty("endColumn")]
        public int EndColumn { get; set; }
    }
}
