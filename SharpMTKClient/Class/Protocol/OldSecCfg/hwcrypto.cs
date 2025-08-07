using SharpMTKClient.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatekNaiveProtocol.Mediatek.OldSecCfg
{
    public class hwcrypto
    {
        public dxcc dxcc;
        public GCpu gcpu;
        public sej sej;
        public cqdma cqdma;
        public int hwcode;
        public uint meid_addr;
        public uint socid_addr;
        public crypto_setup setup;
        public read32Delegate read32;
        public write32Delegate write32;
        public hwcrypto(crypto_setup setup)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public object aes_hwcrypt(byte[] data, byte[] iv = null, bool encrypt = true, byte[] otp = null, string mode = "cbc", string btype = "sej")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}