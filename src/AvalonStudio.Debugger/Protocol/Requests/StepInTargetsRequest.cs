using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// StepInTargets request; value of command field is 'stepInTargets'.
    /// This request retrieves the possible stepIn targets for the specified stack frame.
    /// These targets can be used in the 'stepIn' request.
    /// The StepInTargets may only be called if the 'supportsStepInTargetsRequest' capability exists and is true.
    /// </summary>
    public class StepInTargetsRequest : Request<StepInTargetsArguments>
    {
        private const string COMMAND = "stepInTargets";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'stepInTargets' request.
    /// </summary>
    public class StepInTargetsArguments
    {
        /// <summary>
        /// The stack frame for which to retrieve the possible stepIn targets.
        /// </summary>
        [JsonProperty("frameId")]
        public int FrameId { get; set; }
    }
}
