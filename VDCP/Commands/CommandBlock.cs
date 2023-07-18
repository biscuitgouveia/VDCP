using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VDCP.Commands
{
	public class CommandBlock
	{

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new generic instance of the <see cref="CommandBlock" />
        ///     class when no paramaters are passed in.
        /// </summary>
        public CommandBlock() : this(0x00, 0x00, Array.Empty<byte>())
        { }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CommandBlock" />
        ///     class with the specified Cmd1, Cmd2, and Data.
        /// </summary>
        public CommandBlock(Cmd1 cmd1, byte cmd2, byte[] data)
		{
            Cmd1 = cmd1;
            Cmd2 = cmd2;
            Data = data;
            BitCount = Data.Length + 2;

            byte checkSum = (byte)Cmd1;
            checkSum += Cmd2;

            foreach (var b in Data)
            {
                checkSum += b;
            }

            checkSum = (byte)-(checkSum % 256);

            checkSum &= 0xff;

            CheckSum = checkSum;

            return;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CommandBlock" />
        ///     class when there is no data to pass in.
        /// </summary>
        public CommandBlock(Cmd1 cmd1, byte cmd2) : this(cmd1, cmd2, Array.Empty<byte>())
        { }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CommandBlock" />
        ///     class from a byte buffer of response bits.
        /// </summary>
        public CommandBlock(byte[] buffer)
        {
            BitCount = buffer[1];
            Cmd1 = (Cmd1)buffer[2];

            if (BitCount > 1)
            {
                Cmd2 = buffer[3];

                if (BitCount > 2)
                {
                    Data = new byte[BitCount - 2];

                    for (int i = 4; i < (BitCount + 1); i++)
                    {
                        Data[i - 4] = buffer[i];
                    }
                }
                else
                {
                    Data = Array.Empty<byte>();
                }
            }
        }

        // Todo: Implement Constructor which takes a byte[] Packet and splits it into its Cmd1, Cmd2, Data, and Verifies Checksum

        #endregion

        #region Public Properties

        public Cmd1 Cmd1 { get; set; }

        public byte Cmd2 { get; set; }

        public byte CmdDataCount { get; set; }

        public byte[] Data { get; set; }

        public int BitCount { get; set; }


        #endregion

        #region Public Methods and Operators



        #endregion

        #region Methods

        public byte CheckSum
        {
            get
            {
                return CheckSum;
            }

            set
            {
                byte checkSum = (byte)Cmd1;
                checkSum += Cmd2;

                foreach (var b in Data)
                {
                    checkSum += b;
                }

                checkSum = (byte)-(checkSum % 256);

                checkSum &= 0xff;

                return;
            }
        }

        #endregion
    }
}

