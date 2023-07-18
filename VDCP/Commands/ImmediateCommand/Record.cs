namespace VDCP.Commands.ImmediateCommand
{
    /// <summary>
    /// 
    /// </summary>
    public class Record : CommandBlock
    {
        public Record()
        {
            Cmd1 = Cmd1.ImmediateCommand;
            Cmd2 = (byte)ImmediateCommand.Record;
            BitCount = 0x02;
        }
    }
}