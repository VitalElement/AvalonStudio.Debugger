using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// Next request; value of command field is 'next'.
    /// The request starts the debuggee to run again for one step.
    /// The debug adapter first sends the NextResponse and then a StoppedEvent (event type 'step') after the step has completed.
    /// </summary>
    public class NextRequest : Request<NextArguments>
    {
        private const string COMMAND = "next";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'next' request.
    /// </summary>
    public class NextArguments
    {
        /// <summary>
        /// Execute 'next' for this thread.
        /// </summary>
        [JsonProperty("threadId")]
        public int ThreadId { get; set; }
    }
}
