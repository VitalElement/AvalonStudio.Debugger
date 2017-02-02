using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// StepIn request; value of command field is 'stepIn'.
    /// The request starts the debuggee to step into a function/method if possible.
    /// If it cannot step into a target, 'stepIn' behaves like 'next'.
    /// The debug adapter first sends the StepInResponse and then a StoppedEvent (event type 'step') after the step has completed.
    /// If there are multiple function/method calls (or other targets) on the source line,
    /// the optional argument 'targetId' can be used to control into which target the 'stepIn' should occur.
    /// The list of possible targets for a given source line can be retrieved via the 'stepInTargets' request.
    /// </summary>
    public class StepInRequest : Request<StepInArguments>
    {
        private const string COMMAND = "stepIn";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'stepIn' request.
    /// </summary>
    public class StepInArguments
    {
        /// <summary>
        /// Execute 'stepIn' for this thread.
        /// </summary>
        [JsonProperty("threadId")]
        public int ThreadId { get; set; }

        /// <summary>
        /// Optional id of the target to step into.
        /// </summary>
        [JsonProperty("targetId")]
        public int TargetId { get; set; }
    }
}
