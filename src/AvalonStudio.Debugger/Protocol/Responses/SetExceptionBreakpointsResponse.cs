namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'setExceptionBreakpoints' request. This is just an acknowledgement, so no body field is required.
    /// </summary>
    public class SetExceptionBreakpointsResponse : Response<object>
    {
    }
}
