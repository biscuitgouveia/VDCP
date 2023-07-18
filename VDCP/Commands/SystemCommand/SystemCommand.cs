namespace VDCP.Commands.SystemCommand
{
	/// <summary>
	/// System Command Bytes
	/// </summary>
	public enum SystemCommand : byte
	{
        /// <summary>
        /// Local Disable - disables all operations on its control panel except
        /// REMOTE/LOCAL selection.
		/// </summary>
		LocalDisable = 0x0C,

        /// <summary>
        /// Local Enable = enables control panel operations of the
        /// CONTROLLED DEVICE.
		/// </summary>
		LocalEnable = 0x0D,

        /// <summary>
        /// Delete from Archive - removes the ID from archive storage. It does not remove the ID from the video disk
        /// if it exists there.
        /// </summary>
        DeleteFromArchive = 0x14,

        /// <summary>
        /// Delete Protect ID - prevents an ID from being deleted by an ID DELETE command.
        /// </summary>
        DeleteProtectId = 0x15,

        /// <summary>
        /// Un-Delete Protect ID - the opposite of Protect ID and allows the ID to be deleted but does not delete the
        /// ID by itself.
        /// </summary>
        UnDeleteProtectId = 0x16,

    }
}

