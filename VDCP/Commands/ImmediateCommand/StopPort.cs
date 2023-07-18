namespace VDCP.Commands.ImmediateCommand
{
    /// <summary>
    /// 
    /// </summary>
    public class StopPort : CommandBlock
    {
        public StopPort()
        {
            Cmd1 = Cmd1.ImmediateCommand;
            Cmd2 = (byte)ImmediateCommand.StopPort;
            BitCount = 0x02;
        }
    }
}