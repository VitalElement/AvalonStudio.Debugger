using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// Continue request; value of command field is 'continue'.
    /// The request starts the debuggee to run again.
    /// </summary>
    public class ContinueRequest : Request<ContinueArguments>
    {
        private const string COMMAND = "continue";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'continue' request.
    /// </summary>
    public class ContinueArguments
    {
        /// <summary>
        /// Continue execution for the specified thread (if possible). 
        /// If the backend cannot continue on a single thread but will continue on all threads, it should set the allThreadsContinued attribute in the response to true.
        /// </summary>
        [JsonProperty("threadId")]
        public int ThreadId { get; set; }
    }
}
