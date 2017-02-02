using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// StepBack request; value of command field is 'stepBack'.
    /// The request starts the debuggee to run one step backwards.
    /// The debug adapter first sends the StepBackResponse and then a StoppedEvent (event type 'step') after the step has completed. 
    /// Clients should only call this request if the capability supportsStepBack is true.
    /// </summary>
    public class StepBackRequest : Request<StepBackArguments>
    {
        private const string COMMAND = "stepBack";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'stepBack' request.
    /// </summary>
    public class StepBackArguments
    {
        /// <summary>
        /// Exceute 'stepBack' for this thread.
        /// </summary>
        [JsonProperty("threadId")]
        public int ThreadId { get; set; }
    }
}
