namespace AvalonStudio.Debugger.Protocol.Responses
{
    /// <summary>
    /// Response to 'stepIn' request. This is just an acknowledgement, so no body field is required.
    /// </summary>
    public class StepInResponse : Response<object>
    {
    }
}
