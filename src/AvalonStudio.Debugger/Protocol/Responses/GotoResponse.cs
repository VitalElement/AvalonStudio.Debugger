namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'goto' request. This is just an acknowledgement, so no body field is required.
    /// </summary>
    public class GotoResponse : Response<object>
    {
    }
}
