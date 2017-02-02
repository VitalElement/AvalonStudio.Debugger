using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// Variables request; value of command field is 'variables'.
    /// Retrieves all child variables for the given variable reference.
    /// An optional filter can be used to limit the fetched children to either named or indexed children.
    /// </summary>
    public class VariablesRequest : Request<VariablesArguments>
    {
        private const string COMMAND = "variables";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'variables' request.
    /// </summary>
    public class VariablesArguments
    {
        /// <summary>
        /// The Variable reference.
        /// </summary>
        [JsonProperty("variablesReference")]
        public int VariablesReference { get; set; }

        /// <summary>
        /// Optional filter to limit the child variables to either named or indexed. If ommited, both types are fetched.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("filter")]
        public VariablesArgumentsFilter Filter { get; set; }

        /// <summary>
        /// The index of the first variable to return; if omitted children start at 0.
        /// </summary>
        [JsonProperty("start")]
        public int Start { get; set; }

        /// <summary>
        /// The number of variables to return. If count is missing or 0, all variables are returned.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Specifies details on how to format the Variable values.
        /// </summary>
        [JsonProperty("format")]
        public ValueFormat Format { get; set; }
    }

    public enum VariablesArgumentsFilter { Indexed, Named }
}
