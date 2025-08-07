using SharpMTKClient.Class.Protocol.Native.GPTParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SharpMTKClient.Class.Protocol.Native.gpt;
using static SharpMTKClient.Class.Protocol.Native.mtk_dalegacy;
using static SharpMTKClient.Class.Protocol.Native.mtk_daxflash;

namespace SharpMTKClient.Class.Protocol.Native
{
    public delegate XreadFlashResult readflashDelegate(ulong addr, ulong len, string filename, string parttype = "");
    public delegate Tuple<byte[], gpt> read_pmtDelegate();
    public class Partition
    {
        public Features config;
        public readflashDelegate readflash;
        public read_pmtDelegate read_Pmt;
        public Partition(Features features, readflashDelegate readflash, read_pmtDelegate read_pmt)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<byte[], gpt> get_gpt(gpt_settings gpt_settings, string parttype = "user")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}