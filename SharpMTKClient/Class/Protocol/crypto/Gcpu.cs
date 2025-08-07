using SharpMTKClient.Class;
using SharpMTKClient.Class.Protocol.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MediatekNaiveProtocol.Mediatek.crypto
{
    public class Gcpu
    {
        public class GcpuReg
        {
            public Dictionary<string, uint> Data { get; private set; } = new Dictionary<string, uint>();

            internal uint this[string key, int baseAddress = 0]
            {
                get
                {
                    if (regval.TryGetValue(key, out var value))
                    {
                        return ft.xflash.readmem((value + util.config.chipconfig.gcpu_base + Convert.ToUInt32(baseAddress)), 1)[0];
                    }

                    if (Data.TryGetValue(key, out var value2))
                    {
                        return value2;
                    }

                    return uint.MaxValue;
                }

                set
                {
                    if (regval.TryGetValue(key, out var value2))
                    {
                        ft.xflash.custom_writeregister((value2 + util.config.chipconfig.gcpu_base + Convert.ToUInt32(baseAddress)), value);
                    }
                    else
                    {
                        Data[key] = value;
                    }
                }
            }

            public Features ft;
            public GcpuReg(Features ft)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }
        }

        private const byte CSS_DEC_DK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte CSS_DEC_TK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte CSS_DSC_AV = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte CSS_AUTH_DRV = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte CSS_AUTH_DEC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte CSS_AUTH_BK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte C2_D = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte C2_E = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte C2_G = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte C2_H = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte CPPM_DPAK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte CPRM_DPAK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte CPRM_EPAK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte CPRM_DCI_VFY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AES_CTR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AES_OFB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AES_D = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AES_E = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AES_G = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AES_DPAK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AES_EPAK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AES_CMAC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AES_DCBC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AES_ECBC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AES_H = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AES_D_CMP = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AESEK_D = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AESEK_E = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AESPK_EK_D = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AESPK_EK_E = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AESPK_D = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AESPK_E = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AESPK_DPAK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AESPK_EPAK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AESPK_DCBC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AESPK_ECBC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AESPK_EK_DCBC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte VCPS_H = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte VCPS_DPAK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte VCPS_EPAK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte VCPS_DKBH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte VCPS_DHDK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte VCPS_DCBC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte VCPS_ECBC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AACS_DBD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AACS_EBD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AACS_DTN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AACS_ETN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AACS_DHD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AACS_EHD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte AACS_DV_CALC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte TDES_D = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte TDES_E = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte TDES_DMA_D = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte TDES_DMA_E = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte TDES_CBC_D = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte TDES_CBC_E = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte BDRE_DBD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte BDRE_EBD = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte BDRE_DTN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte BDRE_ETN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte BDRE_BE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte GCPU_WRITE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte GCPU_READ = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte MEMCPY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte DMA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte SHA_1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte SHA_256 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte MD5 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte SHA_224 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte ROM_BIST = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte RNG = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte MEM_XOR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte TS_DESC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte PTX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte RC4DPAK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const byte RC4KSA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CKSYS_BASE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CLR_CLK_GATING_CTRL2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static IReadOnlyDictionary<string, ushort> regval = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private readonly GcpuReg _gcpuReg;
        private static byte[] XorData(IReadOnlyList<byte> a, IReadOnlyList<byte> b, int length = -1)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Features ft;
        public Gcpu(Features ft)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void Reset()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal void Init()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void UnInit()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] MemoryRead(uint address, int length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void MemoryWrite(uint address, params byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void MemoryWrite(uint address, params uint[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal void Acquire()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void Release()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void SetPC(uint address)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private uint ReadReg(uint register)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private uint[] ReadRegs()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void MemptrSet(uint offset, params uint[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] MemptrGet(uint offset, int length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int Cmd(uint cmd, uint address = 0, uint[] args = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int SetModeCmd(bool encrypt = false, string mode = "cbc", bool encryptedKey = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal byte[] aes_read_cbc(uint address, bool encrypt = false, uint keySlot = 18, uint ivSlot = 26)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal void aes_setup_cbc(uint address, byte[] data, byte[] iv = null, bool encrypt = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] ReadMem(uint address, int length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal byte[] MtkGcpuDecryptMteeImg(byte[] data, uint[] keySeed, uint[] ivSeed, uint[] aesKey1, uint[] aesKey2)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal byte[] aes_read_ecb(uint[] data, bool encrypt = false, uint src = 18, uint dst = 26, uint keySlot = 48)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void AesDecryptEcb(uint keyOffset, uint dataOffset, uint outOffset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void AesEncryptEcb(uint keyOffset, uint dataOffset, uint outOffset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] LoadHWKey(uint offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void AesCbc(bool encrypt, uint src, uint dst, uint length = 16, uint keySlot = 18, uint ivSlot = 26)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void AesPkInit()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void AesPkEcb(bool encrypt, uint src, uint dst, uint length = 32)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal byte[] mtk_gcpu_mtee_6735()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal byte[] mtk_gcpu_mtee_8167(bool encrypt = true, uint src = 19, uint dst = 19, uint keySlot = 48)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void DisableRangeBlackList()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}