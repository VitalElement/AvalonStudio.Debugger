using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// GotoTargets request; value of command field is 'gotoTargets'.
    /// This request retrieves the possible goto targets for the specified source location.
    /// These targets can be used in the 'goto' request.
    /// The GotoTargets request may only be called if the 'supportsGotoTargetsRequest' capability exists and is true.
    /// </summary>
    public class GotoTargetsRequest : Request<GotoTargetsArguments>
    {
        private const string COMMAND = "gotoTargets";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'gotoTargets' request.
    /// </summary>
    public class GotoTargetsArguments
    {
        /// <summary>
        /// The source location for which the goto targets are determined.
        /// </summary>
        [JsonProperty("source")]
        public Source Source { get; set; }

        /// <summary>
        /// The line location for which the goto targets are determined.
        /// </summary>
        [JsonProperty("line")]
        public int Line { get; set; }

        /// <summary>
        /// An optional column location for which the goto targets are determined.
        /// </summary>
        [JsonProperty("column")]
        public int Column { get; set; }
    }
}
