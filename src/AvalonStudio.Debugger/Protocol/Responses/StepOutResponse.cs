namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'stepOut' request. This is just an acknowledgement, so no body field is required.
    /// </summary>
    public class StepOutResponse : Response<object>
    {
    }
}
