using SharpMTKClient.Class.Protocol.Native.DAconf;
using MediatekNaiveProtocol.Mediatek;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SharpMTKClient.Class.Protocol.Native.Features;
using static SharpMTKClient.Class.Protocol.Native.gpt;
using static SharpMTKClient.Class.util;
using SharpMTKClient.Class.Protocol.xml;
using static SharpMTKClient.Class.Protocol.MediatekService;

namespace SharpMTKClient.Class.Protocol.Native
{
    public enum DeviceType
    {
        NEWPL,
        Brom
    }

    public struct InitResult
    {
        public bool result;
    }

    public class MtkClient
    {
        public Port SerialPort;
        public Features ft;
        public event LogDelegate log;
        public event ProgressChangedDelegate ProgressChanged;
        private string[] EXIT2_CHIPS;
        public MtkClient()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void Feature_ProgressChanged(ulong max, ulong value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void Feature_Log(string Text, Resut color = Resut.Word)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#region "PL Expolit"
        public InitResult InitDevice()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
        public bool FlashFileByCerberus(string partititonname, string path, string meta = "")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool UnlockBl(bool unlock)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] ReadPreloader()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool ReadRPMB(string filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool RebootPhone()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool ManualFormat(ulong BeginAddress, ulong length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool FormatAll()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool FormatPartitions(string[] PList, string meta = "")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Dictionary<string, string> ReadKeys()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void StartFlash(List<partitionaddr> list, bool reset, string scatter, DlmMode mode = DlmMode.DownloadOnly)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public struct FileData
        {
            public string name;
            public byte[] data;
            public string path;
        }

        public bool FlashFirmware(List<FileData> files, string meta)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<bool, string> ReadRPMBKey()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WriteRPMB(string filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool CrashPreloader()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool EraseRPmb()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<partf> ReadPartitions(string[] partitions, string path, string meta = "")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WriteGPT(string filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WriteGPT(byte[] binary)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WriteFullDump(string filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool ReadFullDump(string filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WritePreloader(byte[] preloader)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<byte[], gpt> ReadGPT()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}