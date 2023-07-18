namespace VDCP.Commands
{
    /// <summary>
    ///     Command 1 Bytes
    /// </summary>
    public enum Cmd1 : byte
    {
        /// <summary>
        ///     System Command
        /// </summary>
        SystemCommand = 0x0,

        /// <summary>
        ///     Immediate Command
        /// </summary>
        ImmediateCommand = 0x1,

        /// <summary>
        ///     Select Command
        /// </summary>
        SelectCommand = 0x2,

        /// <summary>
        ///     Sense Request
        /// </summary>
        SenseRequest = 0x3,

        /// <summary>
        ///     Timeline Command
        /// </summary>
        TimelineCommand = 0x4,

        /// <summary>
        ///     The sense return.
        /// </summary>
        MacroCommand = 0x5,

    }
}