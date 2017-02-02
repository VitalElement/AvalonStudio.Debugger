﻿namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// This enumeration defines all possible conditions when a thrown exception should result in a break.
    /// never: never breaks,
    /// always: always breaks,
    /// unhandled: breaks when excpetion unhandled,
    /// userUnhandled: breaks if the exception is not handled by user code.
    /// </summary>
    public enum ExceptionBreakMode
    {
        Never,
        Always,
        Unhandled,
        UserUnhandled
    }
}
