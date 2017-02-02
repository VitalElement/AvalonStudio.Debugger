using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// runInTerminal request; 
    /// Value of command field is 'runInTerminal'.
    /// With this request a debug adapter can run a command in a terminal.
    /// </summary>
    public class RunInTerminalRequest : Request<RunInTerminalRequestArguments>
    {
        private const string COMMAND = "runInTerminal";
        public override string Command => COMMAND;
    }

    public class RunInTerminalRequestArguments
    {
        /// <summary>
        /// What kind of terminal to launch.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("kind")]
        public TerminalKind Kind { get; set; }

        /// <summary>
        /// Optional title of the terminal.
        /// </summary>
        [JsonProperty("Title")]
        public string Title { get; set; }

        /// <summary>
        /// Working directory of the command.
        /// </summary>
        [JsonProperty("cwd")]
        public string CWD { get; set; }

        /// <summary>
        /// List of arguments. The first argument is the command to run.
        /// </summary>
        [JsonProperty("args")]
        public IList<string> Args { get; set; }

        /// <summary>
        /// Environment key-value pairs that are added to the default environment.
        /// </summary>
        [JsonProperty("env")]
        public TerminalEnvironmentVariables Env { get; set; }
    }

    public class TerminalEnvironmentVariables
    {
        /// <summary>
        /// Values must be strings.
        /// </summary>
        [JsonProperty("additionalProperties")]
        public string AdditionalProperties { get; set; }
    }

    public enum TerminalKind { Integrated, External }
}
