using Newtonsoft.Json;
using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'scopes' request.
    /// </summary>
    public class ScopesResponse : Response<ScopesResponseBody>
    {
    }

    public class ScopesResponseBody
    {
        /// <summary>
        /// The scopes of the stackframe. If the array has length zero, there are no scopes available.
        /// </summary>
        [JsonProperty("scopes")]
        public IList<Scope> Scopes { get; set; } = new List<Scope>();
    }
}
