namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'restartFrame' request. This is just an acknowledgement, so no body field is required.
    /// </summary>
    public class RestartFrameResponse : Response<object>
    {
    }
}
