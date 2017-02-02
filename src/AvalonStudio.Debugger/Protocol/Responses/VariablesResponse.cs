using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'variables' request.
    /// </summary>
    public class VariablesResponse : Response<VariablesResponseBody>
    {
    }

    public class VariablesResponseBody
    {
        /// <summary>
        /// All (or a range) of variables for the given variable reference.
        /// </summary>
        public IList<Variable> Variables { get; set; }
    }
}
