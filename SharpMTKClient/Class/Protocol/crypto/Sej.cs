using SharpMTKClient.Class;
using SharpMTKClient.Class.Protocol.Native;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MediatekNaiveProtocol.Mediatek.crypto
{
    public class Sej
    {
        public Features ft;
        private byte[] CustomSeed;
        public Sej(Features ft)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public class HaccReg
        {
            public Features ft;
            public Dictionary<string, uint> Data { get; private set; } = new Dictionary<string, uint>();

            internal uint this[string key, uint baseAddress = 0]
            {
                get
                {
                    if (regval.TryGetValue(key, out var value))
                    {
                        return ft.xflash.readmem(value + util.config.chipconfig.sej_base + baseAddress, 1)[0];
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
                        ft.xflash.writeregister((value2 + util.config.chipconfig.sej_base + baseAddress), value);
                    }
                    else
                    {
                        Data[key] = value;
                    }
                }
            }

            public HaccReg(Features ft)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }
        }

        private const int AES_CBC_MODE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_SW_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_HW_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_HW_WRAP_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_KEY_128 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_KEY_256 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static IReadOnlyDictionary<string, ushort> regval = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private bool encrypt = true;
        private const uint HACC_AES_DEC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_ENC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_MODE_MASK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_ECB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_CBC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_TYPE_MASK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_128 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_192 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_256 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_CHG_BO_MASK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_CHG_BO_OFF = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_CHG_BO_ON = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_START = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_CLR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_RDY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_BK2C = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_AES_R2K = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_SECINIT0_MAGIC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_SECINIT1_MAGIC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint HACC_SECINIT2_MAGIC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static uint[] g_CFG_RANDOM_PATTERN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static uint[] g_HACC_CFG_1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static uint[] g_HACC_CFG_2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static uint[] g_HACC_CFG_3 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static uint[] g_HACC_CFG_MTEE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private readonly HaccReg _haccReg;
        private int Uffs(uint x)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int TzDaPcSetMasterTransaction(int masterIndex, int permissionControl)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void CryptoSecure(uint val)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void DeviceAPCDomSetup()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void SejSetMode(int mode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void SejSetKey(int key, int flag, byte[] data = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void tz_pre_init()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] sej_run(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void sej_terminate()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public class SymKey
        {
            public byte[] key;
            public int key_len = 0x10;
            public int mode = 1;
            public uint[] iv;
        }

        public byte[] sst_secure_algo_with_level(byte[] buf, bool encrypt = true, bool aes_top_legacy = true, bool legacyxor = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void sst_init(uint attr, uint[] iv, int keylen = 0x10, int mparam = 5, byte[] key = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] generate_hw_meta(byte[] otp = null, bool encrypt = false, byte[] data = null, bool legacy = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public uint sej_aes_hw_init(uint attr, SymKey key, int sej_param = 3)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private uint SEJ_V3_Init(bool ben = true, uint[] iv = null, bool legacy = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal byte[] hw_aes128_cbc_encrypt(byte[] buf, bool encrypt = true, uint[] iv = null, bool legacy = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal void sej_set_otp(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] sej_aes_hw_internal(byte[] data, bool encrypt, uint attr, int sej_param, bool legacy = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] SejDoAes(bool encrypt, byte[] iv, byte[] data, int length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal byte[] generate_rpmb(byte[] meid, byte[] otp, int derivedLen = 32)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] SpHaccInternal(byte[] buf, bool bAc, int user, bool bDoLock, int aesType, bool bEn)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] dev_kdf(byte[] buf, int deriveLen = 16)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] generate_mtee_hw(byte[] otp = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal byte[] generate_mtee(byte[] otp = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal byte[] sej_sec_cfg_sw(byte[] data, bool encrypt_ = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] XorData(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal byte[] sej_sec_cfg_hw(byte[] data, bool encrypt_)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal byte[] sej_sec_cfg_hw_V3(byte[] data, bool encrypt_ = true, bool legacy = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}