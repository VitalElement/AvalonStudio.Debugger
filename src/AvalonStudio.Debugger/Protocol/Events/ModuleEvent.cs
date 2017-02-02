using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AvalonStudio.Debugger.Protocol.Events
{
    /// <summary>
    /// Event message for 'module' event type.
    /// The event indicates that some information about a module has changed.
    /// </summary>
    public class ModuleEvent : DebuggerEvent<ModuleEventBody>
    {
        private const string MODULE = "module";

        public override string Event => MODULE;
    }

    public class ModuleEventBody
    {
        /// <summary>
        /// The new, changed, or removed module. In case of 'removed' only the module id is used.
        /// </summary>
        [JsonProperty("module")]
        public Module Module { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("reason")]
        public ModuleEventReason Reason { get; set; }
    }

    public enum ModuleEventReason { New, Changed, Removed }
}
