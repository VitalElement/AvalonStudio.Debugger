namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'pause' request. 
    /// This is just an acknowledgement, so no body field is required.
    /// </summary>
    public class PauseResponse : Response<object>
    {
    }
}
