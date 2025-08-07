using LibUsbDotNet;
using LibUsbDotNet.Main;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.USBAdapter
{
    public static class SerialPortComm
    {
        public static ItypePort FindPortsWithVidPid(List<Tuple<string, string>> VIDPid, int milisecound)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static ItypePort FindPortsWithVidPid(List<Tuple<string, string>> VIDPid)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static UsbDevice FindListUSB(ItypePort Find, int milisecound)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static UsbDevice FindListUSB(string VID, string PID, int milisecound)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static ManualResetEvent MediatekBrom = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static ManualResetEvent HisiCom1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static ItypePort FindMediatekFlash(int Interval)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static ItypePort FindMediatekFlash()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static ItypePort FindHisiDevice(int Interval)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static ItypePort FindHisiDevice()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}