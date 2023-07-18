namespace VDCP.Commands.ImmediateCommand
{
    /// <summary>
    /// 
    /// </summary>
    public class PlayID : CommandBlock
    {
        public PlayID()
        {
            Cmd1 = Cmd1.ImmediateCommand;
            Cmd2 = (byte)ImmediateCommand.PlayID;
            BitCount = 0x02;
        }
    }
}