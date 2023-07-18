using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VDCP.Commands
{
	public class scratch
	{

        byte Cmd1 = 0x4a;
        byte Cmd2 = 0xab;
        byte[] Data = { 0x6a, 0x59, 0x66 };

		public byte CheckSum
        {
            get
            {
                byte checksum = Cmd1;
                checksum += Cmd2;

                foreach (var b in Data)
                {
                    checksum += b;
                }

                checksum = (byte)-(checksum % 256);

                checksum &= 0xff;

                return checksum;
            }
        }
    }
	}
}

 