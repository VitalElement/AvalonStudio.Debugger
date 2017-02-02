using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// Modules can be retrieved from the debug adapter with the ModulesRequest which can either return all modules or a range of modules to support paging.
    /// </summary>
    public class ModulesRequest : Request<ModulesArguments>
    {
        private const string COMMAND = "modules";
        public override string Command => COMMAND;
    }

    public class ModulesArguments
    {
        /// <summary>
        /// The index of the first module to return; if omitted modules start at 0.
        /// </summary>
        [JsonProperty("startModule")]
        public int StartModule { get; set; }

        /// <summary>
        /// The number of modules to return. If moduleCount is not specified or 0, all modules are returned.
        /// </summary>
        [JsonProperty("moduleCount")]
        public int ModuleCount { get; set; }
    }
}
