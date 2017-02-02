using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// A structured message object. Used to return errors from requests.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Unique identifier for the message.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// A format string for the message. Embedded variables have the form '{name}'.
        /// If variable name starts with an underscore character, the variable does not contain user data (PII) and can be safely used for telemetry purposes.
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; }

        /// <summary>
        /// An object used as a dictionary for looking up the variables in the format string.
        /// </summary>
        [JsonProperty("variables")]
        public MessageVariables Variables { get; set; }

        /// <summary>
        /// If true send to telemetry.
        /// </summary>
        [JsonProperty("sendTelemetry")]
        public bool SendTelemetry { get; set; }

        /// <summary>
        /// If true show user.
        /// </summary>
        [JsonProperty("showUser")]
        public bool ShowUser { get; set; }

        /// <summary>
        /// An optional url where additional information about this message can be found.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// An optional label that is presented to the user as the UI for opening the url.
        /// </summary>
        [JsonProperty("urlLabel")]
        public string UrlLabel { get; set; }
    }

    public class MessageVariables
    {
        /// <summary>
        /// Values must be strings.
        /// </summary>
        [JsonProperty("additionalProperties")]
        public string AdditionalProperties { get; set; }
    }
}
