using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// StepOut request; value of command field is 'stepOut'.
    /// The request starts the debuggee to run again for one step.
    /// The debug adapter first sends the StepOutResponse and then a StoppedEvent (event type 'step') after the step has completed.
    /// </summary>
    public class StepOutRequest : Request<StepOutArguments>
    {
        private const string COMMAND = "stepOut";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'stepOut' request.
    /// </summary>
    public class StepOutArguments
    {
        /// <summary>
        /// Execute 'stepOut' for this thread.
        /// </summary>
        [JsonProperty("threadId")]
        public int ThreadId { get; set; }
    }
}
