using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// Source request; value of command field is 'source'.
    /// The request retrieves the source code for a given source reference.
    /// </summary>
    public class SourceRequest : Request<SourceArguments>
    {
        private const string COMMAND = "source";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'source' request.
    /// </summary>
    public class SourceArguments
    {
        /// <summary>
        /// The reference to the source. This is the value received in Source.reference.
        /// </summary>
        [JsonProperty("sourceReference")]
        public int SourceReference { get; set; }
    }
}
