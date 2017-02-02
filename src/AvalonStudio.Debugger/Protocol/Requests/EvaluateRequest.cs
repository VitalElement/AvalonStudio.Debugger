using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// Evaluate request; value of command field is 'evaluate'.
    /// Evaluates the given expression in the context of the top most stack frame.
    /// The expression has access to any variables and arguments that are in scope.
    /// </summary>
    public class EvaluateRequest : Request<EvaluateArguments>
    {
        private const string COMMAND = "evaluate";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'evaluate' request.
    /// </summary>
    public class EvaluateArguments
    {
        /// <summary>
        /// The expression to evaluate.
        /// </summary>
        [JsonProperty("expression")]
        public string Expression { get; set; }

        /// <summary>
        /// Evaluate the expression in the scope of this stack frame. If not specified, the expression is evaluated in the global scope.
        /// </summary>
        [JsonProperty("frameId")]
        public int FrameId { get; set; }

        /// <summary>
        /// The context in which the evaluate request is run. 
        /// Possible values are 'watch' if evaluate is run in a watch, 'repl' if run from the REPL console, or 'hover' if run from a data hover.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("context")]
        public ContextType Context { get; set; }

        /// <summary>
        /// Specifies details on how to format the Evaluate result.
        /// </summary>
        [JsonProperty("format")]
        public ValueFormat Format { get; set; }
    }

    public enum ContextType { Watch, Repl, Hover }
}
