namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'attach' request. This is just an acknowledgement, so no body field is required.
    /// </summary>
    public class AttachResponse : Response<object>
    {
    }
}
