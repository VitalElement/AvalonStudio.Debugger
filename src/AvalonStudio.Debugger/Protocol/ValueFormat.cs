using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// Provides formatting information for a value.
    /// </summary>
    public class ValueFormat
    {
        /// <summary>
        /// Display the value in hex.
        /// </summary>
        [JsonProperty("hex")]
        public bool Hex { get; set; }
    }
}
