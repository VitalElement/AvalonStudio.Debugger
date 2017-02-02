using Newtonsoft.Json;

namespace AvalonStudio.Debugger.Protocol.Requests
{
    /// <summary>
    /// Launch request; value of command field is 'launch'.
    /// </summary>
    public class LaunchRequest : Request<LaunchRequestBody>
    {
        private const string COMMAND = "launch";
        public override string Command => COMMAND;
    }

    /// <summary>
    /// Arguments for 'launch' request.
    /// </summary>
    public class LaunchRequestBody
    {
        /// <summary>
        /// If noDebug is true the launch request should launch the program without enabling debugging.
        /// </summary>
        [JsonProperty("noDebug")]
        public bool NoDebug { get; set; }
    }
}
