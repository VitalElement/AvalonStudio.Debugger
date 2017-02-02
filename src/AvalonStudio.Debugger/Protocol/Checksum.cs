using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// The checksum of an item calculated by the specified algorithm.
    /// </summary>
    public class Checksum
    {
        /// <summary>
        /// The algorithm used to calculate this checksum.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("algorithm")]
        public ChecksumAlgorithmType Algorithm { get; set; }

        /// <summary>
        /// Value of the checksum.
        /// </summary>
        [JsonProperty("checksum")]
        public string ChecksumValue { get; set; }
    }
    
    public enum ChecksumAlgorithmType { MD5, SHA1, SHA256, timestamp }
}
