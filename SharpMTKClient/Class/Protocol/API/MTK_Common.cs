using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using static SharpMTKClient.Class.Protocol.MTK_DL;

namespace SharpMTKClient.Class.Protocol
{
    public class MTK_Common
    {
        public enum FILTER_TYPE_E
        {
            WHITE_LIST,
            BLACK_LIST
        }

        public partial struct COM_FILTER_LIST_S
        {
            public uint m_uCount;
            public FILTER_TYPE_E m_eType;
            public HandleRef m_ppFilterID;
            public IntPtr m_bInterface;
        }

        public partial struct COM_PROPERTY_S
        {
            public int m_iFilterIndex;
            public uint m_uNumber;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
            public string m_rFriendly;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
            public string m_rInstanceID;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
            public string m_rSymbolic;
            public bool m_bInterface;
        }

        public const ushort MAX_LOAD_SECTIONS = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int OFFSET_ATM = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int KEY1 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int KEY2 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        [DllImport("FlashToolLib.dll", CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "StatusToString")]
        public static extern IntPtr ErrStatusToString(int status)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string StatusToString(int status)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [DllImport("FlashToolLib.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int Brom_Debug_SetLogFilename(byte[] filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [DllImport("FlashToolLib.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int Brom_DebugOn()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [DllImport("FlashToolLib.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int GetSpecialCOMPortWithFilter(ref COM_FILTER_LIST_S pCOMFilter, int dPreferComPort, ref COM_PROPERTY_S pCOMPorperty, IntPtr p_stopflag, double dTimeout)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        public static string decodeOut(string str, int ErrCode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static STATUS_E IntConvertToEnum(uint i)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}