namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'disconnect' request. This is just an acknowledgement, so no body field is required.
    /// </summary>
    public class DisconnectResponse : Response<object>
    {
    }
}
