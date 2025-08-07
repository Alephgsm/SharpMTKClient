using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Win32;
using System.Security;
using System.Runtime.ExceptionServices;
using System.IO;
using System.IO.Ports;
using LibUsbDotNet;
using LibUsbDotNet.Main;
using SharpMTKClient.Class.USBAdapter;

namespace SharpMTKClient.Class.Protocol.Native
{
    public class Port
    {
        public Port()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        //private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        //{
        //    if (e.Mode != PowerModes.Resume)
        //        BromSerial.Close();
        //}
        public struct ReadOutput
        {
            public int ReadedLen;
            public string BitString;
            public byte[] ByteArray;
        }

        public Win32API BromSerial;
        public Win32API GetConfig
        {
            get
            {
                var Genp = new Win32API();
                if (!string.IsNullOrEmpty(this.PortInfo.COM))
                {
                    Genp.PortName = this.PortInfo.COM;
                }

                return Genp;
            }
        }

        public void Handle()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void WriteBuffer(byte[] data, int len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] mtk_cmd(byte[] value, int bytestoread = 0, bool nocmd = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool usbwrite(object command, int pktsize = -1)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool echo(object Arg)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<ushort> rword(int count = 1, bool little = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> rdword(int count = 1, bool little = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] rbyte(int count = 1)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public ReadOutput ReadAsync(int len = 0, int timeout = 30000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public int get_read_packetsize()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public int get_write_packetsize()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public ReadOutput Read(int len = 0, int timeout = 30000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool Open()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void Close()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public struct ResponseCtrlTransfer
        {
            public bool usbFinded;
            public bool Transfered;
        }

        public string vid;
        public string pid;
        ItypePort PortInfo;
        public void SetPort(ItypePort portname)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public ResponseCtrlTransfer ControlTransfer(byte bRequestType, byte bRequest, int wValue, int wIndex, object data_or_wLength)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool ControlTransfer(byte bRequestType, byte bRequest, int wValue, int wIndex, object data_or_wLength, int len = 0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}