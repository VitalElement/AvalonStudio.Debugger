namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'restart' request. This is just an acknowledgement, so no body field is required.
    /// </summary>
    public class RestartResponse : Response<object>
    {
    }
}
