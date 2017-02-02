using Newtonsoft.Json;
using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'gotoTargets' request.
    /// </summary>
    public class GotoTargetsResponse : Response<GotoTargetsResponseBody>
    {
    }

    public class GotoTargetsResponseBody
    {
        /// <summary>
        /// The possible goto targets of the specified location.
        /// </summary>
        [JsonProperty("targets")]
        public IList<GotoTarget> Targets { get; set; }
    }
}
