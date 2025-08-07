using SharpMTKClient.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatekNaiveProtocol.Mediatek.OldSecCfg
{
    public class sej
    {
        public uint HACC_CON;
        public uint HACC_ACON;
        public uint HACC_ACON2;
        public uint HACC_ACONK;
        public uint HACC_ASRC0;
        public uint HACC_ASRC1;
        public uint HACC_ASRC2;
        public uint HACC_ASRC3;
        public uint HACC_AKEY0;
        public uint HACC_AKEY1;
        public uint HACC_AKEY2;
        public uint HACC_AKEY3;
        public uint HACC_AKEY4;
        public uint HACC_AKEY5;
        public uint HACC_AKEY6;
        public uint HACC_AKEY7;
        public uint HACC_ACFG0;
        public uint HACC_ACFG1;
        public uint HACC_ACFG2;
        public uint HACC_ACFG3;
        public uint HACC_AOUT0;
        public uint HACC_AOUT1;
        public uint HACC_AOUT2;
        public uint HACC_AOUT3;
        public uint HACC_SW_OTP0;
        public uint HACC_SW_OTP1;
        public uint HACC_SW_OTP2;
        public uint HACC_SW_OTP3;
        public uint HACC_SW_OTP4;
        public uint HACC_SW_OTP5;
        public uint HACC_SW_OTP6;
        public uint HACC_SW_OTP7;
        public uint HACC_SECINIT0;
        public uint HACC_SECINIT1;
        public uint HACC_SECINIT2;
        public uint HACC_MKJ;
        public uint HACC_UNK;
        public static Dictionary<string, uint> regval = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public class hacc_reg
        {
            public uint sej_base;
            public read32Delegate read32;
            public write32Delegate write32;
            public hacc_reg(crypto_setup setup)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            public bool setattr(string key, uint value)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            public uint getattribute(string key)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }
        }

        public const int AES_CBC_MODE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_SW_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_HW_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_HW_WRAP_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_KEY_128 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_KEY_256 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public bool encrypt = true;
        public uint HACC_AES_DEC = 0x00000000;
        public uint HACC_AES_ENC = 0x00000001;
        public uint HACC_AES_MODE_MASK = 0x00000002;
        public uint HACC_AES_ECB = 0x00000000;
        public uint HACC_AES_CBC = 0x00000002;
        public uint HACC_AES_TYPE_MASK = 0x00000030;
        public uint HACC_AES_128 = 0x00000000;
        public uint HACC_AES_192 = 0x00000010;
        public uint HACC_AES_256 = 0x00000020;
        public uint HACC_AES_CHG_BO_MASK = 0x00001000;
        public uint HACC_AES_CHG_BO_OFF = 0x00000000;
        public uint HACC_AES_CHG_BO_ON = 0x00001000;
        public uint HACC_AES_START = 0x00000001;
        public uint HACC_AES_CLR = 0x00000002;
        public uint HACC_AES_RDY = 0x00008000;
        public uint HACC_AES_BK2C = 0x00000010;
        public uint HACC_AES_R2K = 0x00000100;
        public uint HACC_SECINIT0_MAGIC = 0xAE0ACBEA;
        public uint HACC_SECINIT1_MAGIC = 0xCD957018;
        public uint HACC_SECINIT2_MAGIC = 0x46293911;
        public List<uint> g_CFG_RANDOM_PATTERN;
        public List<uint> g_HACC_CFG_1;
        public List<uint> g_HACC_CFG_2;
        public List<uint> g_HACC_CFG_3;
        public int hwcode;
        public hacc_reg reg;
        public uint sej_base;
        public read32Delegate read32;
        public write32Delegate write32;
        public sej(crypto_setup setup)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void sej_set_otp(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void SEJ_V3_Init(bool ben = true, List<uint> iv = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] SEJ_V3_Run(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void SEJ_V3_Terminate()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        //public async void SEJ_V3_Init(bool encrypt = true, List<uint> iv = null)
        //{
        //    if (iv == null)
        //    {
        //        iv = this.g_HACC_CFG_1;
        //    }
        //    var acon_setting = this.HACC_AES_CHG_BO_OFF | this.HACC_AES_CBC | this.HACC_AES_128;
        //    if (encrypt)
        //    {
        //        acon_setting |= HACC_AES_ENC;
        //    }
        //    else
        //    {
        //        acon_setting |= HACC_AES_DEC;
        //    }
        //    // clear key
        //    reg.setattr("HACC_AKEY0", 0);
        //    reg.setattr("HACC_AKEY1", 0);
        //    reg.setattr("HACC_AKEY2", 0);
        //    reg.setattr("HACC_AKEY3", 0);
        //    reg.setattr("HACC_AKEY4", 0);
        //    reg.setattr("HACC_AKEY5", 0);
        //    reg.setattr("HACC_AKEY6", 0);
        //    reg.setattr("HACC_AKEY7", 0);
        //    // Generate META Key
        //    reg.setattr("HACC_ACON", this.HACC_AES_CHG_BO_OFF | this.HACC_AES_CBC | this.HACC_AES_128 | this.HACC_AES_DEC);
        //    // init ACONK, bind HUID/HUK to HACC, this may differ
        //    // enable R2K, so that output data is feedback to key by HACC internal algorithm
        //    reg.setattr("HACC_ACONK", this.HACC_AES_BK2C | this.HACC_AES_R2K);// g_AC_CFG
        //    // clear HACC_ASRC/HACC_ACFG/HACC_AOUT
        //    reg.setattr("HACC_ACON2", this.HACC_AES_CLR);
        //    reg.setattr("HACC_UNK", 1);
        //    reg.setattr("HACC_ACFG0", iv[0]);
        //    reg.setattr("HACC_ACFG1", iv[1]);
        //    reg.setattr("HACC_ACFG2", iv[2]);
        //    reg.setattr("HACC_ACFG3", iv[3]);
        //    foreach(var i in util.Range(0 , 3))
        //    {
        //        var pos = i * 4;
        //        reg.setattr("HACC_ASRC0", g_CFG_RANDOM_PATTERN[pos]);
        //        reg.setattr("HACC_ASRC1", g_CFG_RANDOM_PATTERN[pos + 1]);
        //        reg.setattr("HACC_ASRC2", g_CFG_RANDOM_PATTERN[pos + 2]);
        //        reg.setattr("HACC_ASRC3", g_CFG_RANDOM_PATTERN[pos + 3]);
        //        reg.setattr("HACC_ACON2", HACC_AES_START);
        //        while(true)
        //        {
        //            var Get = await reg.getattribute("HACC_ACON2" );
        //            if((Get & HACC_AES_RDY) != 0)
        //            {
        //                break;
        //            }
        //        }
        //    }
        //    reg.setattr("HACC_ACON2", this.HACC_AES_CLR);
        //    reg.setattr("HACC_UNK", 1);
        //    reg.setattr("HACC_ACFG0", iv[0]);
        //    reg.setattr("HACC_ACFG1", iv[1]);
        //    reg.setattr("HACC_ACFG2", iv[2]);
        //    reg.setattr("HACC_ACFG3", iv[3]);
        //    reg.setattr("HACC_ACON", acon_setting);
        //    reg.setattr("HACC_ACONK", 0);
        //}
        //public async Task<byte[]> SEJ_V3_Run(byte[] data)
        //{
        //    var pdst = new List<byte>();
        //    var psrc = bytes_to_dwords(data);
        //    var plen = psrc.Count;
        //    var pos = 0;
        //    foreach (var i in util.Range(0, plen / 4))
        //    {
        //        reg.setattr("HACC_ASRC0", psrc[pos + 0]);
        //        reg.setattr("HACC_ASRC1", psrc[pos + 1]);
        //        reg.setattr("HACC_ASRC2", psrc[pos + 2]);
        //        reg.setattr("HACC_ASRC3", psrc[pos + 3]);
        //        reg.setattr("HACC_ACON2", 1);
        //        while (true)
        //        {
        //            var get = await reg.getattribute("HACC_ACON2" );
        //            if ((get & HACC_AES_RDY) != 0)
        //            {
        //                break;
        //            }
        //        }
        //        var Get = await reg.getattribute("HACC_AOUT0" );
        //        pdst.AddRange(StructConverter.Pack("<I", new object[] { Get }));
        //        Get = await reg.getattribute("HACC_AOUT1" );
        //        pdst.AddRange(StructConverter.Pack("<I", new object[] { Get }));
        //        Get = await reg.getattribute("HACC_AOUT2" );
        //        pdst.AddRange(StructConverter.Pack("<I", new object[] { Get }));
        //        Get = await reg.getattribute("HACC_AOUT3" );
        //        pdst.AddRange(StructConverter.Pack("<I", new object[] { Get }));
        //        pos += 4;
        //    }
        //    return pdst.ToArray();
        //}
        //public async void SEJ_V3_Terminate()
        //{
        //    reg.setattr("HACC_ACON2", this.HACC_AES_CLR);
        //    reg.setattr("HACC_AKEY0", 0);
        //    reg.setattr("HACC_AKEY1", 0);
        //    reg.setattr("HACC_AKEY2", 0);
        //    reg.setattr("HACC_AKEY3", 0);
        //    reg.setattr("HACC_AKEY4", 0);
        //    reg.setattr("HACC_AKEY5", 0);
        //    reg.setattr("HACC_AKEY6", 0);
        //    reg.setattr("HACC_AKEY7", 0);
        //}
        public uint SEJ_Init(bool encrypt = true, List<uint> iv = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] SEJ_Run(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void SEJ_Terminate()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] xor_data(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] sej_sec_cfg_hw_V3(byte[] data, bool encrypt = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] sej_sec_cfg_hw(byte[] data, bool encrypt = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] sej_sec_cfg_sw(byte[] data, bool encrypt = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void sej_set_mode(int mode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void sej_set_key(int key, int flag, byte[] data = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> bytes_to_dwords(byte[] buf)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] sej_do_aes(bool encrypt, byte[] iv, byte[] data, int length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] hw_aes128_cbc_encrypt(byte[] buf, bool encrypt, List<uint> iv = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] generate_mtee(byte[] otp = null)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] dev_kdf(byte[] buf, int derivelen = 16)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] sp_hacc_internal(byte[] buf, bool bAC, int user, bool bDoLock, int aes_type, bool bEn)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] generate_rpmb(byte[] mid, byte[] otp, int derivedlen = 32)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}