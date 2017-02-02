using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// A Thread
    /// </summary>
    public class Thread
    {
        /// <summary>
        /// Unique identifier for the thread.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// A name of the thread.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
