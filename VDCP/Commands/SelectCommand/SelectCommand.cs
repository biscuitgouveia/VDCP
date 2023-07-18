namespace VDCP.Commands.SelectCommand
{
	public enum SelectCommand : byte
	{
		/// <summary>
		///
		/// </summary>
		ClosePort = 0x21,

        /// <summary>
        ///
        /// </summary>
		SelectPort = 0x22,

        /// <summary>
        ///
        /// </summary>
        RecordInit = 0x23,

        /// <summary>
		///
		/// </summary>
        PlayCue = 0x24,

        /// <summary>
		///
		/// </summary>
        DeleteID = 0x26,

    }
}

