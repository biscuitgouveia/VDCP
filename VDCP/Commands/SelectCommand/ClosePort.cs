namespace VDCP.Commands.SelectCommand
{
    /// <summary>
    /// 
    /// </summary>
    public class ClosePort : CommandBlock
    {
        public ClosePort(byte[] data)
        {
            Cmd1 = Cmd1.SelectCommand;
            Cmd2 = (byte)SelectCommand.ClosePort;
            Data = data;
            BitCount = 0x03;
        }
    }
}