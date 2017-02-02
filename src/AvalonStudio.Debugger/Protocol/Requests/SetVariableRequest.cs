using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// setVariable request; value of command field is 'setVariable'.
    /// Set the variable with the given name in the variable container to a new value.
    /// </summary>
    public class SetVariableRequest : Request<SetVariableArguments>
    {
        private const string COMMAND = "setVariable";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'setVariable' request.
    /// </summary>
    public class SetVariableArguments
    {
        /// <summary>
        /// The reference of the variable container.
        /// </summary>
        [JsonProperty("variablesReference")]
        public int VariablesReference { get; set; }

        /// <summary>
        /// The name of the variable.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The value of the variable.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
