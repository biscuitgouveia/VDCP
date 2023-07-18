namespace VDCP.Commands.ImmediateCommand
{
    /// <summary>
    ///	Immediate Command Bytes
    /// </summary>
    public enum ImmediateCommand : byte
	{
        /// <summary>
        /// Stop - return the selected port to the IDLE state.
		/// </summary>
		StopPort = 0x00,

        /// <summary>
        /// Play ID - plays the specified ID
		/// </summary>
		PlayID = 0x01,

        /// <summary>
        /// Record - cause the system to begin recording on the next REF interval.
        /// It will also clear the CUE/INIT and cueing bits in the port status.
		/// </summary>
		Record = 0x02,

        /// <summary>
        /// Freeze - cause the system to "TAKE" a single frame from the incoming video
        /// stream (input port only).
		/// </summary>
		Freeze = 0x03,

        /// <summary>
        /// Still ID - pause the currently playing ID. The last frame played prior to receiving
        /// the STILL command will continue being displayed.
		/// </summary>
		StillId = 0x04,

        /// <summary>
        /// Step ID - cause the currently playing and paused ID in STILL state or in a play state to
        /// advance to the next frame and STILL. The output port must be in a PLAY, CUED, or STILL state
        /// or an error will be logged. This is equivalent to JOG with +1 data.
		/// </summary>
		StepId = 0x05,

        /// <summary>
        /// Continue ID - causes the ID currently in the STILL state or a PLAY STATE to exit
        /// that state and continue playing. The output port must be in a PLAY, CUED, or STILL state or an
        /// error will be logged.
		/// </summary>
		ContinueId = 0x06,

        /// <summary>
        /// Jog - causes the controlled device to move the specified number of frames forward or
        /// backward with respect to its current position. The output port must be in a PLAY, CUED, or STILL
        /// state or an error will be logged.
		/// </summary>
		Jog = 0x07,

        /// <summary>
        /// Variable Play - the controlled device will start running in
        /// accordance with the speed and direction data defined in SEND DATA-1, SEND DATA-2, and
        /// SEND DATA-3. The output port must be in a PLAY, CUED, or STILL state or an error will be
        /// logged. The port state will then be in PLAY.
		/// </summary>
		VariablePlay = 0x08,

        /// <summary>
        /// Un-Freeze - causes the system to return to standard input.
		/// </summary>
		UnFreeze = 0x09,

        /// <summary>
        /// EE Mode - SEND DATA 1 specifies the EE MODE to put the output in.
		/// </summary>
		EeMode = 0x0A,

    }
}

