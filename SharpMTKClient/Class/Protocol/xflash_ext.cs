using SharpMTKClient.Class.Protocol.Native.DAconf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.Protocol.Native
{
    public static class xflash_ext
    {
        public static string da_x
        {
            get
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            set
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }
        }

        public static string da_xml
        {
            get
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }

            set
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }
        }

        public static uint? op_mov_to_offset(uint firstOp, uint secondOp, int register)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] Patchv6(byte[] daextdata, byte[] da2, uint da2address, ref chipconfig ch)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name = "data"></param>
        /// <param name = "strf"></param>
        /// <param name = "pos"></param>
        /// <returns>-2 is null</returns>
        public static int find_binary(byte[] data, byte[] strf, int pos = 0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private static byte[][] SplitBytes(byte[] input, byte delimiter)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private static int ArrayFind(byte[] array, byte[] pattern, int start)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] patch(byte[] daextdata, byte[] da2, uint da2address, ref chipconfig ch)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] patch2(byte[] daextdata, byte[] da2, uint da2address, ref chipconfig ch)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private static void WriteUIntToArray(byte[] data, int offset, uint value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] fix_hash(byte[] da1, byte[] da2, int hashpos, int hashmode, int hashlen)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] patch_da11(byte[] da1)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] patch_da1(byte[] da1)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] patch_preloader_security_da1(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] patch_preloader_security_da2(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] patch_da22(byte[] da2, DA da)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] patch_da2(byte[] da2, uint m_start_addr)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}