using SharpMTKClient.Class;
using SharpMTKClient.Class.Protocol.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MediatekNaiveProtocol.Mediatek.crypto
{
    public class Dxcc
    {
        private enum DescDirection : uint
        {
            DESC_DIRECTION_ILLEGAL = uint.MaxValue,
            DESC_DIRECTION_ENCRYPT_ENCRYPT = 0u,
            DESC_DIRECTION_DECRYPT_DECRYPT = 1u,
            DESC_DIRECTION_DECRYPT_ENCRYPT = 3u,
            DESC_DIRECTION_END = uint.MaxValue
        }

        private enum sep_engine_type : uint
        {
            SEP_ENGINE_NULL,
            SEP_ENGINE_AES,
            SEP_ENGINE_DES,
            SEP_ENGINE_HASH,
            SEP_ENGINE_RC4,
            SEP_ENGINE_DOUT
        }

        private enum sep_crypto_alg : uint
        {
            SEP_CRYPTO_ALG_NULL = uint.MaxValue,
            SEP_CRYPTO_ALG_AES = 0u,
            SEP_CRYPTO_ALG_DES = 1u,
            SEP_CRYPTO_ALG_HASH = 2u,
            SEP_CRYPTO_ALG_RC4 = 3u,
            SEP_CRYPTO_ALG_C2 = 4u,
            SEP_CRYPTO_ALG_HMAC = 5u,
            SEP_CRYPTO_ALG_AEAD = 6u,
            SEP_CRYPTO_ALG_BYPASS = 7u,
            SEP_CRYPTO_ALG_COMBINED = 8u,
            SEP_CRYPTO_ALG_NUM = 9u,
            SEP_CRYPTO_ALG_RESERVE32B = uint.MaxValue
        }

        private enum sep_crypto_direction : uint
        {
            SEP_CRYPTO_DIRECTION_NULL = uint.MaxValue,
            SEP_CRYPTO_DIRECTION_ENCRYPT = 0u,
            SEP_CRYPTO_DIRECTION_DECRYPT = 1u,
            SEP_CRYPTO_DIRECTION_DECRYPT_ENCRYPT = 3u,
            SEP_CRYPTO_DIRECTION_RESERVE32B = uint.MaxValue
        }

        private enum sep_cipher_mode : uint
        {
            SEP_CIPHER_NULL_MODE = uint.MaxValue,
            SEP_CIPHER_ECB = 0u,
            SEP_CIPHER_CBC = 1u,
            SEP_CIPHER_CTR = 2u,
            SEP_CIPHER_CBC_MAC = 3u,
            SEP_CIPHER_XTS = 4u,
            SEP_CIPHER_XCBC_MAC = 5u,
            SEP_CIPHER_OFB = 6u,
            SEP_CIPHER_CMAC = 7u,
            SEP_CIPHER_CCM = 8u,
            SEP_CIPHER_CBC_CTS = 11u,
            SEP_CIPHER_GCTR = 12u,
            SEP_CIPHER_RESERVE32B = uint.MaxValue
        }

        private enum sep_hash_mode : uint
        {
            SEP_HASH_NULL = uint.MaxValue,
            SEP_HASH_SHA1 = 0u,
            SEP_HASH_SHA256 = 1u,
            SEP_HASH_SHA224 = 2u,
            SEP_HASH_SHA512 = 3u,
            SEP_HASH_SHA384 = 4u,
            SEP_HASH_MD5 = 5u,
            SEP_HASH_CBC_MAC = 6u,
            SEP_HASH_XCBC_MAC = 7u,
            SEP_HASH_CMAC = 8u,
            SEP_HASH_MODE_NUM = 9u,
            SEP_HASH_RESERVE32B = uint.MaxValue
        }

        private enum sep_hash_hw_mode : uint
        {
            SEP_HASH_HW_MD5 = 0u,
            SEP_HASH_HW_SHA1 = 1u,
            SEP_HASH_HW_SHA256 = 2u,
            SEP_HASH_HW_SHA224 = 10u,
            SEP_HASH_HW_SHA512 = 4u,
            SEP_HASH_HW_SHA384 = 12u,
            SEP_HASH_HW_GHASH = 6u,
            SEP_HASH_HW_RESERVE32B = uint.MaxValue
        }

        private enum sep_c2_mode : uint
        {
            SEP_C2_NULL = uint.MaxValue,
            SEP_C2_ECB = 0u,
            SEP_C2_CBC = 1u,
            SEP_C2_RESERVE32B = uint.MaxValue
        }

        private enum sep_multi2_mode : uint
        {
            SEP_MULTI2_NULL = uint.MaxValue,
            SEP_MULTI2_ECB = 0u,
            SEP_MULTI2_CBC = 1u,
            SEP_MULTI2_OFB = 2u,
            SEP_MULTI2_RESERVE32B = uint.MaxValue
        }

        private enum sep_crypto_key_type : uint
        {
            SEP_USER_KEY = 0u,
            SEP_ROOT_KEY = 1u,
            SEP_PROVISIONING_KEY = 2u,
            SEP_SESSION_KEY = 3u,
            SEP_APPLET_KEY = 4u,
            SEP_END_OF_KEYS = uint.MaxValue
        }

        private enum DmaMode : uint
        {
            DMA_MODE_NULL = uint.MaxValue,
            NO_DMA = 0u,
            DMA_SRAM = 1u,
            DMA_DLLI = 2u,
            DMA_MLLI = 3u
        }

        private enum FlowMode
        {
            FLOW_MODE_NULL = -1,
            BYPASS = 0,
            DIN_AES_DOUT = 1,
            AES_to_HASH = 2,
            AES_and_HASH = 3,
            DIN_DES_DOUT = 4,
            DES_to_HASH = 5,
            DES_and_HASH = 6,
            DIN_HASH = 7,
            DIN_HASH_and_BYPASS = 8,
            AESMAC_and_BYPASS = 9,
            AES_to_HASH_and_DOUT = 10,
            DIN_RC4_DOUT = 11,
            DES_to_HASH_and_DOUT = 12,
            AES_to_AES_to_HASH_and_DOUT = 13,
            AES_to_AES_to_HASH = 14,
            AES_to_HASH_and_AES = 15,
            DIN_MULTI2_DOUT = 16,
            DIN_AES_AESMAC = 17,
            HASH_to_DOUT = 18,
            S_DIN_to_AES = 32,
            S_DIN_to_AES2 = 33,
            S_DIN_to_DES = 34,
            S_DIN_to_RC4 = 35,
            S_DIN_to_MULTI2 = 36,
            S_DIN_to_HASH = 37,
            S_AES_to_DOUT = 38,
            S_AES2_to_DOUT = 39,
            S_RC4_to_DOUT = 41,
            S_DES_to_DOUT = 42,
            S_HASH_to_DOUT = 43,
            SET_FLOW_ID = 44
        }

        private enum SetupOp : uint
        {
            SETUP_LOAD_NOP = 0u,
            SETUP_LOAD_STATE0 = 1u,
            SETUP_LOAD_STATE1 = 2u,
            SETUP_LOAD_STATE2 = 3u,
            SETUP_LOAD_KEY0 = 4u,
            SETUP_LOAD_XEX_KEY = 5u,
            SETUP_WRITE_STATE0 = 8u,
            SETUP_WRITE_STATE1 = 9u,
            SETUP_WRITE_STATE2 = 10u,
            SETUP_WRITE_STATE3 = 11u
        }

        private enum AesMacSelector : uint
        {
            AES_SK = 1u,
            AES_CMAC_INIT,
            AES_CMAC_SIZE0
        }

        private enum HwCryptoKey : uint
        {
            USER_KEY = 0u,
            ROOT_KEY = 1u,
            PROVISIONING_KEY = 2u,
            SESSION_KEY = 3u,
            RESERVED_KEY = 4u,
            PLATFORM_KEY = 5u,
            CUSTOMER_KEY = 6u,
            KFDE0_KEY = 7u,
            KFDE1_KEY = 9u,
            KFDE2_KEY = 10u,
            KFDE3_KEY = 11u
        }

        private enum HwAesKeySize : uint
        {
            AES_128_KEY,
            AES_192_KEY,
            AES_256_KEY
        }

        private enum HwDesKeySize : uint
        {
            DES_ONE_KEY,
            DES_TWO_KEYS,
            DES_THREE_KEYS
        }

        private class DxccReg
        {
            public Dictionary<string, uint> Data { get; private set; } = new Dictionary<string, uint>();

            internal uint this[string key]
            {
                get
                {
                    if (regval.TryGetValue(key, out var value))
                    {
                        return ft.xflash.readmem((value + util.config.chipconfig.sej_base), 1)[0];
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
                        ft.xflash.custom_writeregister((value2 + util.config.chipconfig.sej_base), value);
                    }
                    else
                    {
                        Data[key] = value;
                    }
                }
            }

            public Features ft;
            public DxccReg(Features ft)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }
        }

        private const ushort DX_HOST_IRR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const ushort DX_HOST_ICR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const ushort DX_DSCRPTR_QUEUE0_WORD0 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const ushort DX_DSCRPTR_QUEUE0_WORD1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const ushort DX_DSCRPTR_QUEUE0_WORD2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const ushort DX_DSCRPTR_QUEUE0_WORD3 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const ushort DX_DSCRPTR_QUEUE0_WORD4 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const ushort DX_DSCRPTR_QUEUE0_WORD5 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const ushort DX_DSCRPTR_QUEUE0_CONTENT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const ushort DX_HOST_SEP_HOST_GPR0 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const ushort DX_HOST_SEP_HOST_GPR1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const ushort DX_HOST_SEP_HOST_GPR2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const ushort DX_HOST_SEP_HOST_GPR3 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const ushort DX_HOST_SEP_HOST_GPR4 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int SB_AXI_ID = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AXI_SECURE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_MD5_DIGEST_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_SHA1_DIGEST_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_SHA224_DIGEST_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_SHA256_DIGEST_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_SHA384_DIGEST_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_SHA512_DIGEST_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_MD5_BLOCK_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_SHA1_BLOCK_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_SHA224_BLOCK_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_SHA256_BLOCK_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_SHA384_BLOCK_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_SHA512_BLOCK_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_BLOCK_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_IV_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_CCM_NONCE_LENGTH_MIN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_CCM_NONCE_LENGTH_MAX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_CCM_TAG_LENGTH_MIN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_CCM_TAG_LENGTH_MAX = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int DES_IV_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int SB_COUNTER_ID = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_BLOCK_SIZE_IN_WORDS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_IV_COUNTER_SIZE_IN_WORDS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_IV_COUNTER_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_KEY_SIZE_IN_WORDS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_KEY_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_Key128Bits_SIZE_IN_WORDS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_Key128Bits_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_Key256Bits_SIZE_IN_WORDS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int AES_Key256Bits_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_DIGEST_SIZE_IN_WORDS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_DIGEST_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_LENGTH_SIZE_IN_WORDS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int HASH_LENGTH_SIZE_IN_BYTES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static Dictionary<string, object> AES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static Dictionary<string, object> MISC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static Dictionary<string, List<int>> CC_CTL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static Dictionary<string, object> DIN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static Dictionary<string, object> DOUT = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static Dictionary<string, object> DES = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static Dictionary<string, object> DSCRPTR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static Dictionary<string, object> HASH = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private static Dictionary<string, object> AXI = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private string oem_pubk = "DACD8B5FDA8A766FB7BCAA43F0B16915CE7B47714F1395FDEBCF12A2D41155B0FB587A51FECCCB4DDA1C8E5EB9EB69B86DAF2C620F6C2735215A5F22C0B6CE377AA0D07EB38ED340B5629FC2890494B078A63D6D07FDEACDBE3E7F27FDE4B143F49DB4971437E6D00D9E18B56F02DABEB0000B6E79516D0C8074B5A42569FD0D9196655D2A4030D42DFE05E9F64883E6D5F79A5BFA3E7014C9A62853DC1F21D5D626F4D0846DB16452187DD776E8886B48C210C9E208059E7CAFC997FD2CA210775C1A5D9AA261252FB975268D970C62733871D57814098A453DF92BC6CA19025CD9D430F02EE46F80DE6C63EA802BEF90673AAC4C6667F2883FB4501FA77455";
        private string huawei_med_lx9 = "C1A9D3E65C7EAEB31932E9DD224C07C070D879FB4FE518C64E92C24B79DC1EE1535D91D38DD34D7E32A22DEED60F0727FF8F8747E2598ACB5DDC73C61D2434A91D568FE3E773BD0D17AA46B0364E0DCF3B41E0034605D572B6CD7DD8A816E7D684181B1646628576D1E22F55071687B9E5B2F9C9536167B7EDCF10F1F85BE57B6EE873BFE952BB33F0001140E0E46AF2D64D39C568D8E372BCE3609BCACA5316E4EBDDE5721B33611E064DF41A4BCF0A3A395791D3203BF220DC71F4267093CEB78E30A844D4631DE8CE6D0514202BB58AD2024B16558C2AD9B30CE05043FF67C4D265A3D5F3275D93AFDC1A39625C2C5BD6FDCDBD75E76E6D9E74E9672B5897";
        private static Dictionary<string, ushort> regval = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private readonly DxccReg _reg;
        private static uint[] hw_desc_init()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private static uint BitMask(int maskSize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private static uint ToValue(int value, int bitSize, int shift)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint[] hw_desc_set_cipher_mode(uint[] pDesc, int cipherMode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint[] hw_desc_set_cipher_config0(uint[] pDesc, int cipherConfig)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint[] hw_desc_set_cipher_config1(uint[] pDesc, int cipherConfig)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint[] hw_desc_set_setup_mode(uint[] pDesc, int setupMode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint[] hw_desc_set_flow_mode(uint[] pDesc, int flowMode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint[] hw_desc_set_dout_sram(uint[] pDesc, uint doutAdr, int doutSize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint[] hw_desc_set_dout_dlli(uint[] pDesc, uint doutAdr, int doutSize, int axiNs, int lastind)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint[] hw_desc_set_key_size_aes(uint[] pDesc, int keySize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint[] hw_desc_set_din_sram(uint[] pDesc, int dinAdr, int dinSize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint[] hw_desc_set_din_const(uint[] pDesc, int val, int dinSize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint[] hw_desc_set_cipher_do(uint[] pDesc, int cipherDo)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint[] hw_desc_set_din_nodma(uint[] pDesc, int dinAdr, int dinSize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint[] hw_desc_set_din_type(uint[] pDesc, int dmaMode, int dinAdr, int dinSize, int axiId, int axiNs)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public Features ft;
        public Dxcc(Features ft)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void sb_hal_init()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private uint SBCryptoWait()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void SasiPaldmaunmap(int value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int SasiPaldmamap(int value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private bool tzcc_clk(int value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal byte[] generate_itrustee_fbe(int keySize = 32)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] generate_rpmb_mitee()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal byte[] generate_rpmb(byte level)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public (byte[] platkey, byte[] provkey) generate_provision_key()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal byte[] generate_sha256(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void sbrom_sha256(byte[] buffer, long destAddr)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private uint SBROMCryptoFinishDriver(long outputptr)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void SBROMCryptoUpdate(long inputptr, long outputptr, int blockSize, bool islastblock, int cryptodrivermode, int waitforcrypto)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void SBROMCryptoInitDriver(long aesIvPtr, int cryptoDriverMode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] sbrom_key_derivation(HwCryptoKey aeskeytype, byte[] label, byte[] salt, int requestedlen, long destaddr)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private long sbrom_aes_cmac(HwCryptoKey aesKeyType, uint internalKey, byte[] dataIn, DmaMode dmaMode, int bufferlen, uint destaddr)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private bool sbrom_aes_cmac_driver(HwCryptoKey aesKeyType, int pInternalKey, int pDataIn, DmaMode dmaMode, int blockSize, long pDataOut)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void sasi_sb_adddescsequence(IReadOnlyList<uint> data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private uint sb_hal_wait_desc_completion(long destptr = 0L)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] MteeDcrypt(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] descramble(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}