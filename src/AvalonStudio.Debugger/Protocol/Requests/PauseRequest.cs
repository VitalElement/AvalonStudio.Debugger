using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// Pause request; value of command field is 'pause'.
    /// The request suspenses the debuggee.
    /// The debug adapter first sends the PauseResponse and then a StoppedEvent (event type 'pause') after the thread has been paused successfully.
    /// </summary>
    public class PauseRequest : Request<PauseArguments>
    {
        private const string COMMAND = "pause";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'pause' request.
    /// </summary>
    public class PauseArguments
    {
        /// <summary>
        /// Pause execution for this thread.
        /// </summary>
        [JsonProperty("threadId")]
        public int ThreadId { get; set; }
    }
}
