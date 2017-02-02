using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// RestartFrame request; value of command field is 'restartFrame'.
    /// The request restarts execution of the specified stackframe.
    /// The debug adapter first sends the RestartFrameResponse and then a StoppedEvent (event type 'restart') after the restart has completed.
    /// </summary>
    public class RestartFrameRequest : Request<RestartFrameArguments>
    {
        private const string COMMAND = "restartFrame";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'restartFrame' request.
    /// </summary>
    public class RestartFrameArguments
    {
        /// <summary>
        /// Restart this stackframe.
        /// </summary>
        [JsonProperty("frameId")]
        public int FrameId { get; set; }
    }
}
