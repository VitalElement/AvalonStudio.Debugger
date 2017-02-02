using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// Information about the capabilities of a debug adapter.
    /// </summary>
    public class Capabilities
    {
        /// <summary>
        /// The debug adapter supports the configurationDoneRequest.
        /// </summary>
        [JsonProperty("supportsConfigurationDoneRequest")]
        public bool SupportsConfigurationDoneRequest { get; set; }

        /// <summary>
        /// The debug adapter supports function breakpoints.
        /// </summary>
        [JsonProperty("supportsFunctionBreakpoints")]
        public bool SupportsFunctionBreakpoints { get; set; }

        /// <summary>
        /// The debug adapter supports conditional breakpoints.
        /// </summary>
        [JsonProperty("supportsConditionalBreakpoints")]
        public bool SupportsConditionalBreakpoints { get; set; }

        /// <summary>
        /// The debug adapter supports breakpoints that break execution after a specified number of hits.
        /// </summary>
        [JsonProperty("supportsHitConditionalBreakpoints")]
        public bool SupportsHitConditionalBreakpoints { get; set; }

        /// <summary>
        /// The debug adapter supports a (side effect free) evaluate request for data hovers.
        /// </summary>
        [JsonProperty("supportsEvaluateForHovers")]
        public bool SupportsEvaluateForHovers { get; set; }

        /// <summary>
        /// Available filters or options for the setExceptionBreakpoints request.
        /// </summary>
        [JsonProperty("exceptionBreakpointFilters")]
        public IList<ExceptionBreakpointsFilter> ExceptionBreakpointFilters { get; set; }

        /// <summary>
        /// The debug adapter supports stepping back via the stepBack and reverseContinue requests.
        /// </summary>
        [JsonProperty("supportsStepBack")]
        public bool SupportsStepBack { get; set; }

        /// <summary>
        /// The debug adapter supports setting a variable to a value.
        /// </summary>
        [JsonProperty("supportsSetVariable")]
        public bool SupportsSetVariable { get; set; }

        /// <summary>
        /// The debug adapter supports restarting a frame.
        /// </summary>
        [JsonProperty("supportsRestartFrame")]
        public bool SupportsRestartFrame { get; set; }

        /// <summary>
        /// The debug adapter supports the gotoTargetsRequest.
        /// </summary>
        [JsonProperty("supportsGotoTargetsRequest")]
        public bool SupportsGotoTargetsRequest { get; set; }

        /// <summary>
        /// The debug adapter supports the stepInTargetsRequest.
        /// </summary>
        [JsonProperty("supportsStepInTargetsRequest")]
        public bool SupportsStepInTargetsRequest { get; set; }

        /// <summary>
        /// The debug adapter supports the completionsRequest.
        /// </summary>
        [JsonProperty("supportsCompletionsRequest")]
        public bool SupportsCompletionsRequest { get; set; }

        /// <summary>
        /// The debug adapter supports the modules request.
        /// </summary>
        [JsonProperty("supportsModulesRequest")]
        public bool SupportsModulesRequest { get; set; }

        /// <summary>
        /// The set of additional module information exposed by the debug adapter.
        /// </summary>
        [JsonProperty("additionalModuleColumns")]
        public IList<ColumnDescriptor> AdditionalModuleColumns { get; set; }

        /// <summary>
        /// Checksum algorithms supported by the debug adapter.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("supportedChecksumAlgorithms")]
        public IList<ChecksumAlgorithmType> SupportedChecksumAlgorithms { get; set; }

        /// <summary>
        /// The debug adapter supports the RestartRequest. 
        /// In this case a client should not implement 'restart' by terminating and relaunching the adapter but by calling the RestartRequest.
        /// </summary>
        [JsonProperty("supportsRestartRequest")]
        public bool SupportsRestartRequest { get; set; }

        /// <summary>
        /// The debug adapter supports 'exceptionOptions' on the setExceptionBreakpoints request.
        /// </summary>
        [JsonProperty("supportsExceptionOptions")]
        public bool SupportsExceptionOptions { get; set; }

        /// <summary>
        /// The debug adapter supports a 'format' attribute on the stackTraceRequest, variablesRequest, and evaluateRequest.
        /// </summary>
        [JsonProperty("supportsValueFormattingOptions")]
        public bool SupportsValueFormattingOptions { get; set; }
    }
}
