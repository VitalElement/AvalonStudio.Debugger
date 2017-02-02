namespace AvalonStudio.Debugger.Protocol.Events
{
    /// <summary>
    /// Event message for 'initialized' event type.
    /// This event indicates that the debug adapter is ready to accept configuration requests (e.g. SetBreakpointsRequest, SetExceptionBreakpointsRequest).
    /// A debug adapter is expected to send this event when it is ready to accept configuration requests (but not before the InitializeRequest has finished).
    /// The sequence of events/requests is as follows:
    /// - adapters sends InitializedEvent (after the InitializeRequest has returned)
    /// - frontend sends zero or more SetBreakpointsRequest
    /// - frontend sends one SetFunctionBreakpointsRequest
    /// - frontend sends a SetExceptionBreakpointsRequest if one or more exceptionBreakpointFilters have been defined (or if supportsConfigurationDoneRequest is not defined or false)
    /// - frontend sends other future configuration requests
    /// - frontend sends one ConfigurationDoneRequest to indicate the end of the configuration
    /// </summary>
    public class InitializedEvent : DebuggerEvent<string>
    {
        private const string INITIALIZED = "initialized";

        public override string Event => INITIALIZED;
    }
}
