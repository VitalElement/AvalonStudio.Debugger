using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// CompletionItems are the suggestions returned from the CompletionsRequest.
    /// </summary>
    public class CompletionItem
    {
        /// <summary>
        /// The label of this completion item. By default this is also the text that is inserted when selecting this completion.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// If text is not falsy then it is inserted instead of the label.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// The item's type. Typically the client uses this information to render the item in the UI with an icon.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public CompletionItemType Type { get; set; }

        /// <summary>
        /// When a completion is selected it replaces 'length' characters starting at 'start' in the text passed to the CompletionsRequest.
        /// If missing the frontend will try to determine these values heuristically.
        /// </summary>
        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }
    }

    public enum CompletionItemType
    {
        Method,
        Function,
        Constructor,
        Field,
        Variable,
        Class,
        Interface,
        Module,
        Property,
        Unit,
        Value,
        Enum,
        Keyword,
        Snippet,
        Text,
        Color,
        File,
        Reference,
        CustomColor
    }
}
