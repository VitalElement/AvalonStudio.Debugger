using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// Scopes request; value of command field is 'scopes'.
    /// The request returns the variable scopes for a given stackframe ID.
    /// </summary>
    public class ScopesRequest : Request<ScopesArguments>
    {
        private const string COMMAND = "scopes";
        public override string Command => COMMAND;
    }

    public class ScopesArguments
    {
        /// <summary>
        /// Retrieve the scopes for this stackframe.
        /// </summary>
        [JsonProperty("frameId")]
        public int FrameId { get; set; }
    }
}
