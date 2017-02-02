using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// CompletionsRequest request; value of command field is 'completions'.
    /// Returns a list of possible completions for a given caret position and text.
    /// The CompletionsRequest may only be called if the 'supportsCompletionsRequest' capability exists and is true.
    /// </summary>
    public class CompletionsRequest : Request<CompletionsArguments>
    {
        private const string COMMAND = "completions";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'completions' request.
    /// </summary>
    public class CompletionsArguments
    {
        /// <summary>
        /// Returns completions in the scope of this stack frame. If not specified, the completions are returned for the global scope
        /// </summary>
        [JsonProperty("frameId")]
        public int FrameId { get; set; }

        /// <summary>
        /// One or more source lines. Typically this is the text a user has typed into the debug console before he asked for completion.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// The character position for which to determine the completion proposals.
        /// </summary>
        [JsonProperty("column")]
        public int Column { get; set; }

        /// <summary>
        /// An optional line for which to determine the completion proposals. If missing the first line of the text is assumed.
        /// </summary>
        [JsonProperty("line")]
        public int Line { get; set; }
    }
}
