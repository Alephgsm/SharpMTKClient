using SharpMTKClient.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatekNaiveProtocol.Mediatek.OldSecCfg
{
    public class GCpu
    {
        public uint gcpu_base;
        public int hwcode;
        public GCpuReg reg;
        public read32Delegate read32;
        public write32Delegate write32;
        public GCpu(crypto_setup setup)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public int CSS_DEC_DK = 0x00; // CSS Disk Key Decryption
        public int CSS_DEC_TK = 0x01; // CSS Title Key Decryption
        public int CSS_DSC_AV = 0x02; // CSS AV Descramble
        public int CSS_AUTH_DRV = 0x03; // CSS Drive Authentication
        public int CSS_AUTH_DEC = 0x04; // CSS Decoder Authentication
        public int CSS_AUTH_BK = 0x05; // CSS Key Share Authentication
        public int C2_D = 0x08; // CPPM/CPRM C2 Decryption
        public int C2_E = 0x09; // CPPM/CPRM C2 Encryption
        public int C2_G = 0x0A; // CPPM/CPRM C2 Generating Function
        public int C2_H = 0x0B; // CPPM/CPRM C2 Hash Function
        public int CPPM_DPAK = 0x0C; // CPPM Packet Decryption
        public int CPRM_DPAK = 0x0D; // CPRM Packet Decryption
        public int CPRM_EPAK = 0x0E; // CPRM Packet Encryption
        public int CPRM_DCI_VFY = 0x0F; // CPRM DCI CCI Verify
        public int AES_CTR = 0x1E; // AES CTR Function
        public int AES_OFB = 0x1F; // AES OFB Function
        public int AES_D = 0x20; // AES Decryption Function
        public int AES_E = 0x21; // AES Encryption Function
        public int AES_G = 0x22; // AES Generating Function
        public int AES_DPAK = 0x23; // AES Packet Decryption
        public int AES_EPAK = 0x24; // AES Packet Encryption
        public int AES_CMAC = 0x25; // AES CMAC Algorithm
        public int AES_DCBC = 0x26; // AES Cipher Block Chaining Decryption
        public int AES_ECBC = 0x27; // AES Cipher Block Chaining Encryption
        public int AES_H = 0x28; // AES Hash
        public int AES_D_CMP = 0x36; // AES Decryption Function with Result Compare
        public int AESEK_D = 0x74; // AES Decryption with Enc key
        public int AESEK_E = 0x75; // AES Encryption with Enc key
        public int AESPK_EK_D = 0x76; // AES Decryption with Predetermined/Encrypted key
        public int AESPK_EK_E = 0x77; // AES Encryption with Predetermined/Encrypted key
        public int AESPK_D = 0x78; // AES Decryption with Predetermined Key
        public int AESPK_E = 0x79; // AES Encryption with Predetermined Key
        public int AESPK_DPAK = 0x7A; // AES Packet Decryption with Predetermined Key
        public int AESPK_EPAK = 0x7B; // AES Packet Encryption with Predetermined Key
        public int AESPK_DCBC = 0x7C; // AES Cipher Block Chaining Decryption with Predetermined Key
        public int AESPK_ECBC = 0x7D; // AES Cipher Block Chaining Encryption with Predetermined Key
        public int AESPK_EK_DCBC = 0x7E; // AES Cipher Block Chaining Decryption with Predetermined/Encrypted Key
        public int VCPS_H = 0x28; // VCPS Hash Function
        public int VCPS_DPAK = 0x29; // VCPS Packet Decryption
        public int VCPS_EPAK = 0x2A; // VCPS Packet Encryption
        public int VCPS_DKBH = 0x2B; // VCPS DKB Hash Function
        public int VCPS_DHDK = 0x2C; // VCPS Hardware Device Key Decryption
        public int VCPS_DCBC = 0x2D; // VCPS AES Cipher Block Chaining Decryption
        public int VCPS_ECBC = 0x2E; // VCPS AES Cipher Block Chaining Encryption
        public int AACS_DBD = 0x30; // AACS Blu-ray AV Packet Decryption
        public int AACS_EBD = 0x31; // AACS Blu-ray AV Packet Encryption
        public int AACS_DTN = 0x32; // AACS Blu-ray Thumbnail Packet Decryption
        public int AACS_ETN = 0x33; // AACS Blu-ray Thumbnail Packet Encryption
        public int AACS_DHD = 0x34; // AACS HD-DVD Packet Decryption
        public int AACS_EHD = 0x35; // AACS HD-DVD Packet Encryption
        public int AACS_DV_CALC = 0x37; // AACS DV Calculation
        public int TDES_D = 0x50; // T-DES Decryption
        public int TDES_E = 0x51; // T-DES Encryption
        public int TDES_DMA_D = 0x52; // T-DES DMA Decryption
        public int TDES_DMA_E = 0x53; // T-DES DMA Encryption
        public int TDES_CBC_D = 0x54; // T-DES Cipher Block Chaining Decryption
        public int TDES_CBC_E = 0x55; // T-DES Cipher Block Chaining Encryption
        public int BDRE_DBD = 0x58; // BDRE AV Packet Decryption
        public int BDRE_EBD = 0x59; // BDRE AV Packet Encryption
        public int BDRE_DTN = 0x5A; // BDRE Thumbnail Packet Decryption
        public int BDRE_ETN = 0x5B; // BDRE Thumbnail Packet Encryption
        public int BDRE_BE = 0x5C; // BDRE BytePerm and ExtendKey
        public int GCPU_WRITE = 0x6e;
        public int GCPU_READ = 0x6f;
        public int MEMCPY = 0x10; // DRAM Data Moving
        public int DMA = 0x11; // DRAM Direct Memory Access
        public int SHA_1 = 0x40; // SHA-1 Algorithm
        public int SHA_256 = 0x41; // SHA-256 Algorithm
        public int MD5 = 0x42; // MD5 Algorithm
        public int SHA_224 = 0x43; // SHA-224 Algorithm
        public int ROM_BIST = 0x5E;
        public int RNG = 0x6B;
        public int MEM_XOR = 0x71; // Memory XOR
        public int TS_DESC = 0x81; // TS descramble
        public int PTX = 0x8c;
        public int RC4DPAK = 0x87;
        public int RC4KSA = 0x88;
        public byte[] aes_read_cbc(uint addr, bool encrypt = false, uint keyslot = 18, uint ivslot = 26)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool aes_setup_cbc(uint addr, byte[] data, byte[] iv = null, bool encrypt = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool aes_cbc(bool encrypt, uint src, uint dst, uint length, uint keyslot = 18, uint ivslot = 26)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] aes_read_ecb(byte[] data, bool encrypt = false, uint src = 0x12, uint dst = 0x1a, uint keyslot = 0x30)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool aes_decrypt_ecb(uint key_offset, uint data_offset, uint out_offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] memptr_get(uint offset, int length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public int set_mode_cmd(bool encrypt = false, string mode = "cbc", bool encryptedkey = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool aes_encrypt_ecb(uint key_offset, uint data_offset, uint out_offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] load_hw_key(uint offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> to_dwords(byte[] buf)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void memptr_set(uint offset, byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public int cmd(uint cmd, uint addr = 0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}