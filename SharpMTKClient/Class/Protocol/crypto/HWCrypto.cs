using SharpMTKClient.Class;
using SharpMTKClient.Class.Protocol.Native;
using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace MediatekNaiveProtocol.Mediatek.crypto
{
    public class HWCrypto
    {
        public Dxcc dxcc { get; }
        public Gcpu Gcpu { get; }
        public Sej sej { get; }
        public Cqdma Cqdma { get; }

        public Features ft;
        public HWCrypto(Features ft)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal byte[] Mtee(byte[] data, uint[] keySeed, uint[] ivSeed, uint[] aesKey1, uint[] aesKey2)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal object aes_hwcrypt(byte[] data = null, byte[] iv = null, bool encrypt = true, byte[] otp = null, string mode = "cbc", string btype = "sej")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal void Orval(uint address, uint value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal void AndVal(uint address, uint value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal void DisableHypervisor()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}