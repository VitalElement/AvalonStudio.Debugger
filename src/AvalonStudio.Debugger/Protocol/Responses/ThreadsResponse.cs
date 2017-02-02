using Newtonsoft.Json;
using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'threads' request.
    /// </summary>
    public class ThreadsResponse : Response<ThreadsResponseBody>
    {
    }

    public class ThreadsResponseBody
    {
        /// <summary>
        /// All threads.
        /// </summary>
        [JsonProperty("threads")]
        public IList<Thread> Threads { get; set; }
    }
}
