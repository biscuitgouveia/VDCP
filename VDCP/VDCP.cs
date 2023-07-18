using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;

using VDCP.Commands;

namespace VDCP
{
    public class VDCP
    {

        #region Fields

        /// <summary>
        ///     Serial Port Object
        /// </summary>
        protected readonly SerialPort Serial = new();

        #endregion

        #region Constructors and Deconstructors

        public VDCP()
        {
            Debug.Assert(null != Serial, "SerialPort is null");

            Serial.BaudRate = 38400;
            Serial.DataBits = 8;
            Serial.StopBits = StopBits.One;
            Serial.Parity = Parity.Odd;
            Serial.Handshake = Handshake.None;
            Serial.DtrEnable = true;
            Serial.RtsEnable = true;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the port name.
        /// </summary>
        public string PortName
        {
            get
            {
                Debug.Assert(null != Serial, "internal serial port is null");
                return Serial.PortName;
            }

            private set
            {
                Debug.Assert(null != Serial, "internal serial port is null");
                Serial.PortName = value;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Close the serial port
        /// </summary>
        public void Close()
        {
            try
            {
                // If bytes are available in the input queue, then just read them here.
                // (but they will be lost)
                if (Serial.IsOpen)
                {
                    // Discards Data from the serial driver's receive/transmit Buffer.
                    Serial.DiscardInBuffer();
                    Serial.DiscardOutBuffer();

                    Serial.Close();
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.Message);
            }
        }

        public bool Open(string portName)
        {
            PortName = portName;

            var portNames = SerialPort.GetPortNames();
            if (!portNames.Contains(PortName))
            {
                return false;
            }

            try
            {
                Debug.Assert(false == Serial.IsOpen, "internal serial port should not be open at this stage");

                Serial.Open();
            }
            catch (Exception e)
            {
                Trace.TraceError(e.Message);
                return false;
            }

            return true;
        }

        #endregion
    }
}
