using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class
{
    public class StructConverter
    {
        public static byte[] TypeAgnosticGetBytes<T>(T val, bool indian)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static int calcsize(string fmt)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        //    private static string GetFormatSpecifierFor(object o)
        //    {
        //        if (o is int) return "i";
        //        if (o is uint) return "I";
        //        if (o is long) return "q";
        //        if (o is ulong) return "Q";
        //        if (o is short) return "h";
        //        if (o is ushort) return "H";
        //        if (o is byte) return "B";
        //        if (o is sbyte) return "b";
        //        throw new ArgumentException(util.GetKey("FailedPack"));
        //}
        public static T FromBuffer<T>(byte[] buffer, bool LittleEndian)
            where T : struct
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        //private static Packer pack = new Packer();
        public static object[] Unpack(string fmt, byte[] bytes)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name = "fmt"> <is little  and> is bigger </is></param>
        /// <param name = "items"></param>
        /// <returns></returns>
        public static byte[] Pack(string fmt, object[] items)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}