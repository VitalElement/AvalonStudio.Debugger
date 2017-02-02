using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// ReverseContinue request; value of command field is 'reverseContinue'.
    /// The request starts the debuggee to run backward. 
    /// Clients should only call this request if the capability supportsStepBack is true.
    /// </summary>
    public class ReverseContinueRequest : Request<ReverseContinueArguments>
    {
        private const string COMMAND = "reverseContinue";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'reverseContinue' request.
    /// </summary>
    public class ReverseContinueArguments
    {
        /// <summary>
        /// Exceute 'reverseContinue' for this thread.
        /// </summary>
        [JsonProperty("threadId")]
        public int ThreadId { get; set; }
    }
}
