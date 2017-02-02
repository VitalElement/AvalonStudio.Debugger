using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// Goto request; value of command field is 'goto'.
    /// The request sets the location where the debuggee will continue to run.
    /// This makes it possible to skip the execution of code or to executed code again.
    /// The code between the current location and the goto target is not executed but skipped.
    /// The debug adapter first sends the GotoResponse and then a StoppedEvent (event type 'goto').
    /// </summary>
    public class GotoRequest : Request<GotoArguments>
    {
        private const string COMMAND = "goto";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'goto' request.
    /// </summary>
    public class GotoArguments
    {
        /// <summary>
        /// Set the goto target for this thread.
        /// </summary>
        [JsonProperty("threadId")]
        public int ThreadId { get; set; }

        /// <summary>
        /// The location where the debuggee will continue to run.
        /// </summary>
        [JsonProperty("targetId")]
        public int TargetId { get; set; }
    }
}
