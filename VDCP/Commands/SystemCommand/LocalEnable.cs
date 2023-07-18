namespace VDCP.Commands.SystemCommand
{
    /// <summary>
    /// 
    /// </summary>
    public class LocalEnable : CommandBlock
    {
        public LocalEnable()
        {
            Cmd1 = Cmd1.SystemCommand;
            Cmd2 = (byte)SystemCommand.LocalEnable;
            BitCount = 0x02;
        }
    }
}