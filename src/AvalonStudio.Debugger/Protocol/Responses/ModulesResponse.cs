using Newtonsoft.Json;
using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'modules' request.
    /// </summary>
    public class ModulesResponse : Response<ModulesResponseBody>
    {
    }

    public class ModulesResponseBody
    {
        /// <summary>
        /// All modules or range of modules.
        /// </summary>
        [JsonProperty("modules")]
        public IList<Module> Modules { get; set; }

        /// <summary>
        /// The total number of modules available.
        /// </summary>
        [JsonProperty("totalModules")]
        public int TotalModules { get; set; }
    }
}
