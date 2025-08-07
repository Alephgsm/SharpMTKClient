using SharpMTKClient.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatekNaiveProtocol.Mediatek.OldSecCfg
{
    public class dxcc
    {
        public class HwCryptoKey
        {
            public const int USER_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int ROOT_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int PROVISIONING_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int SESSION_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int RESERVED_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int PLATFORM_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int CUSTOMER_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int KFDE0_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int KFDE1_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int KFDE2_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const int KFDE3_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class sep_cipher_mode
        {
            public const uint SEP_CIPHER_NULL_MODE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_CIPHER_ECB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_CIPHER_CBC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_CIPHER_CTR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_CIPHER_CBC_MAC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_CIPHER_XTS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_CIPHER_XCBC_MAC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_CIPHER_OFB = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_CIPHER_CMAC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_CIPHER_CCM = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_CIPHER_CBC_CTS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_CIPHER_GCTR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_CIPHER_RESERVE32B = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class DescDirection
        {
            public const uint DESC_DIRECTION_ILLEGAL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DESC_DIRECTION_ENCRYPT_ENCRYPT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DESC_DIRECTION_DECRYPT_DECRYPT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DESC_DIRECTION_DECRYPT_ENCRYPT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DESC_DIRECTION_END = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class DmaMode
        {
            public const uint DMA_MODE_NULL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint NO_DMA = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DMA_SRAM = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DMA_DLLI = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DMA_MLLI = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class FlowMode
        {
            //public const uint FLOW_MODE_NULL = -1;
            public const uint BYPASS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DIN_AES_DOUT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint AES_to_HASH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint AES_and_HASH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DIN_DES_DOUT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DES_to_HASH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DES_and_HASH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DIN_HASH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DIN_HASH_and_BYPASS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint AESMAC_and_BYPASS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint AES_to_HASH_and_DOUT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DIN_RC4_DOUT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DES_to_HASH_and_DOUT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint AES_to_AES_to_HASH_and_DOUT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint AES_to_AES_to_HASH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint AES_to_HASH_and_AES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DIN_MULTI2_DOUT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint DIN_AES_AESMAC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint HASH_to_DOUT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint S_DIN_to_AES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint S_DIN_to_AES2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint S_DIN_to_DES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint S_DIN_to_RC4 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint S_DIN_to_MULTI2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint S_DIN_to_HASH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint S_AES_to_DOUT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint S_AES2_to_DOUT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint S_RC4_to_DOUT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint S_DES_to_DOUT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint S_HASH_to_DOUT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SET_FLOW_ID = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class SetupOp
        {
            public const uint SETUP_LOAD_NOP = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SETUP_LOAD_STATE0 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SETUP_LOAD_STATE1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SETUP_LOAD_STATE2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SETUP_LOAD_KEY0 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SETUP_LOAD_XEX_KEY = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SETUP_WRITE_STATE0 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SETUP_WRITE_STATE1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SETUP_WRITE_STATE2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SETUP_WRITE_STATE3 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class sep_hash_hw_mode
        {
            public const uint SEP_HASH_HW_MD5 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_HW_SHA1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_HW_SHA256 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_HW_SHA224 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_HW_SHA512 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_HW_SHA384 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_HW_GHASH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_HW_RESERVE32B = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public class sep_hash_mode
        {
            public const uint SEP_HASH_NULL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_SHA1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_SHA256 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_SHA224 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_SHA512 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_SHA384 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_MD5 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_CBC_MAC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_XCBC_MAC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_CMAC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_MODE_NUM = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
            public const uint SEP_HASH_RESERVE32B = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        }

        public const int DX_HOST_IRR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int DX_HOST_ICR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // DX_CC = (HOST_RGF, HOST_ICR)
        public const int DX_DSCRPTR_QUEUE0_WORD0 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int DX_DSCRPTR_QUEUE0_WORD1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int DX_DSCRPTR_QUEUE0_WORD2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int DX_DSCRPTR_QUEUE0_WORD3 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int DX_DSCRPTR_QUEUE0_WORD4 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int DX_DSCRPTR_QUEUE0_WORD5 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int DX_DSCRPTR_QUEUE0_CONTENT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int DX_HOST_SEP_HOST_GPR0 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */; // DX_HOST_SEP_HOST_GPR0_REG_OFFSET
        public const int DX_HOST_SEP_HOST_GPR1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int DX_HOST_SEP_HOST_GPR2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int DX_HOST_SEP_HOST_GPR3 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int DX_HOST_SEP_HOST_GPR4 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int INT32_MAX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int SB_AXI_ID = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AXI_SECURE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int HASH_MD5_DIGEST_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int HASH_SHA1_DIGEST_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int HASH_SHA224_DIGEST_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int HASH_SHA256_DIGEST_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int HASH_SHA384_DIGEST_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int HASH_SHA512_DIGEST_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int HASH_MD5_BLOCK_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int HASH_SHA1_BLOCK_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int HASH_SHA224_BLOCK_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int HASH_SHA256_BLOCK_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int HASH_SHA384_BLOCK_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int HASH_SHA512_BLOCK_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_BLOCK_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_IV_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_CCM_NONCE_LENGTH_MIN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_CCM_NONCE_LENGTH_MAX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_CCM_TAG_LENGTH_MIN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_CCM_TAG_LENGTH_MAX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int DES_IV_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        // Use constant counter ID and AXI ID;
        public const int SB_COUNTER_ID = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        // The AES block size in words and in bytes;
        public const int AES_BLOCK_SIZE_IN_WORDS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        // The size of the IV or counter buffer;
        public const int AES_IV_COUNTER_SIZE_IN_WORDS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_IV_COUNTER_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        // The size of the AES KEY in words and bytes;
        public const int AES_KEY_SIZE_IN_WORDS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_KEY_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_Key128Bits_SIZE_IN_WORDS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_Key128Bits_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_Key256Bits_SIZE_IN_WORDS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int AES_Key256Bits_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        // Hash IV+Length;
        public const int HASH_DIGEST_SIZE_IN_WORDS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int HASH_DIGEST_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int HASH_LENGTH_SIZE_IN_WORDS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int HASH_LENGTH_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public bool SB_HalClearInterruptBit()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public uint dxcc_base;
        public uint gcpu_base;
        public uint da_payload_addr;
        public uint sej_base;
        public List<Tuple<uint, uint>> blacklist;
        public uint meid_addr;
        public uint socid_addr;
        public read32Delegate read32;
        public write32Delegate write32;
        public writememDelegate writemem;
        public string oem_pubk;
        public int hwcode;
        public Dictionary<string, object> DSCRPTR;
        public dxcc(crypto_setup setup)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] generate_sha256(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public int sbrom_sha256(byte[] buffer, uint destaddr)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public uint sbrom_cryptofinishdriver(uint outputptr)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public uint sbrom_cryptoupdate(uint inputptr, uint outputptr, uint blockSize, int islastblock, int cryptodrivermode, int waitforcrypto)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void sbrom_cryptoinitdriver(uint aesivptr, uint cryptodrivermode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Tuple<byte[], byte[]> generate_provision_key()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] generate_itrustee_fbe(int key_sz = 32)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool tzcc_clk(int value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] generate_rpmb(byte level = 0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] SBROM_KeyDerivation(int aeskeytype, byte[] label, byte[] salt, uint requestedlen, uint destaddr)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public uint SBROM_AesCmac(int aesKeyType, byte[] InternalKey, byte[] DataIn, int dmaMode, int bufferlen, uint destaddr)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool SB_HalInit()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> hw_desc_init()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool SBROM_AesCmacDriver(int aesKeyType, uint pInternalKey, uint pDataIn, int dmaMode, uint blockSize, uint pDataOut)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public int sasi_paldmamap(int value1)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public uint SB_CryptoWait()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public uint SB_HalWaitDescCompletion(uint destptr = 0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void sasi_paldmaunmap(int value1)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> hw_desc_set_din_nodma(List<uint> pDesc, uint dinAdr, uint dinSize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> hw_desc_set_dout_dlli(List<uint> pDesc, uint doutAdr, uint doutSize, uint axiNs, uint lastind)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> hw_desc_set_dout_sram(List<uint> pDesc, uint doutAdr, uint doutSize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> hw_desc_set_din_type(List<uint> pDesc, uint dmaMode, uint dinAdr, uint dinSize, uint axiId, uint axiNs)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void sasi_sb_adddescsequence(List<uint> data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> hw_desc_set_cipher_do(List<uint> pDesc, uint cipherDo)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> hw_desc_set_setup_mode(List<uint> pDesc, uint setupMode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> hw_desc_set_flow_mode(List<uint> pDesc, uint flowMode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> hw_desc_set_din_const(List<uint> pDesc, int val, int dinSize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> hw_desc_set_din_sram(List<uint> pDesc, uint dinAdr, uint dinSize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> hw_desc_set_key_size_aes(List<uint> pDesc, uint keySize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> hw_desc_set_cipher_config0(List<uint> pDesc, uint cipherMode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> hw_desc_set_cipher_config1(List<uint> pDesc, uint cipherConfig)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<uint> hw_desc_set_cipher_mode(List<uint> pDesc, uint cipherMode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public uint tovalue(uint value, int bitsize, int shift)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}