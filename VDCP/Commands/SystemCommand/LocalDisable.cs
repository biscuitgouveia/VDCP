namespace VDCP.Commands.SystemCommand
{
    /// <summary>
    /// 
    /// </summary>
    public class LocalDisable : CommandBlock
	{
		public LocalDisable()
		{
			Cmd1 = Cmd1.SystemCommand;
			Cmd2 = (byte)SystemCommand.LocalDisable;
            BitCount = 0x02;
        }
	}
}