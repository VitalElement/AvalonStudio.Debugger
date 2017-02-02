using Newtonsoft.Json;
using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'stepInTargets' request.
    /// </summary>
    public class StepInTargetsResponse : Response<StepInTargetsResponseBody>
    {
    }

    public class StepInTargetsResponseBody
    {
        /// <summary>
        /// The possible stepIn targets of the specified source location.
        /// </summary>
        [JsonProperty("targets")]
        public IList<StepInTarget> Targets { get; set; }
    }
}
