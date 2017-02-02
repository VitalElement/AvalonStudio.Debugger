namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'stepBack' request. This is just an acknowledgement, so no body field is required.
    /// </summary>
    public class StepBackResponse : Response<object>
    {
    }
}
