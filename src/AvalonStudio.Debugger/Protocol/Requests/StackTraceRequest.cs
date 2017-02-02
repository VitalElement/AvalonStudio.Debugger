using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// StackTrace request; value of command field is 'stackTrace'. The request returns a stacktrace from the current execution state.
    /// </summary>
    public class StackTraceRequest : Request<StackTraceArguments>
    {
        private const string COMMAND = "stackTrace";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'stackTrace' request.
    /// </summary>
    public class StackTraceArguments
    {
        /// <summary>
        /// Retrieve the stacktrace for this thread.
        /// </summary>
        [JsonProperty("threadId")]
        public int ThreadId { get; set; }

        /// <summary>
        /// The index of the first frame to return; if omitted frames start at 0.
        /// </summary>
        [JsonProperty("startFrame")]
        public int StartFrame { get; set; }

        /// <summary>
        /// The maximum number of frames to return. If levels is not specified or 0, all frames are returned.
        /// </summary>
        [JsonProperty("levels")]
        public int Levels { get; set; }

        /// <summary>
        /// Specifies details on how to format the stack frames.
        /// </summary>
        [JsonProperty("format")]
        public StackFrameFormat Format { get; set; }
    }
}
