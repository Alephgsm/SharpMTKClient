using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.Protocol.Native
{
    public class Win32API
    {
        private const uint GENERIC_READ = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, GENERIC_WRITE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, GENERIC_EXECUTE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, GENERIC_ALL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CBR_110 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, CBR_300 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, CBR_600 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, CBR_1200 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, CBR_2400 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, CBR_4800 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, CBR_9600 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, CBR_14400 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, CBR_19200 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, CBR_38400 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, CBR_56000 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, CBR_57600 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, CBR_115200 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, CBR_128000 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, CBR_256000 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, FILE_TYPE_UNKNOWN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, FILE_TYPE_DISK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, FILE_TYPE_CHAR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, FILE_TYPE_PIPE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, FILE_TYPE_REMOTE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, FALSE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, TRUE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, DTR_CONTROL_ENABLE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, RTS_CONTROL_ENABLE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */, OPEN_EXISTING = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private COMSTAT comStat;
        private string pname;
        public string PortName
        {
            get
            {
                return pname;
            }

            set
            {
                pname = value;
            }
        }

        public bool IsOpen
        {
            get
            {
                return hSerial != null;
            }
        }

        internal int BytesToRead
        {
            get
            {
                uint errorCode = 0; // "ref" arguments need to have values, as opposed to "out" arguments
                if (ClearCommError(hSerial, out errorCode, out comStat) <= 0)
                {
                    return 0;
                }

                return (int)comStat.cbInQue;
            }
        }

        public void SetReadWriteTimeout(int interval)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private SafeFileHandle hSerial;
        public bool reconfigure()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public const int FILE_FLAG_OVERLAPPED = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public const int FILE_ATTRIBUTE_NORMAL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public bool Open()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void Close()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool IsValidPTr()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private unsafe int write(byte* bytes, int count)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public string ReadExisting()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private unsafe int read(byte* buff, int len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool Write(string args)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public unsafe bool writeData(byte[] data, int len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public unsafe int readdata(byte[] buff, int len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void flush()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void flushInput()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void flushOutput()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        private static extern int CloseHandle(SafeFileHandle hObject)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", SetLastError = true)]
        internal static extern int GetFileType(UIntPtr hFile // handle to file
        )
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        private static extern UIntPtr CreateFileW(string lpFileName, UInt32 dwDesiredAccess, UInt32 dwShareMode, UIntPtr lpSecurityAttributes, UInt32 dwCreationDisposition, UInt32 dwFlagsAndAttributes, UIntPtr hTemplateFile)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern SafeFileHandle CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern bool PurgeComm(SafeFileHandle hFile, // handle to communications resource
 uint dwFlags // action to perform
        )
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", SetLastError = true)]
        unsafe internal static extern bool WriteFile(SafeFileHandle handle, byte* bytes, int numBytesToWrite, out int numBytesWritten, IntPtr lpOverlapped)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        //    [DllImport("kernel32.dll", SetLastError = true)]
        //    public static extern bool WriteFile(
        //SafeFileHandle hFile,
        //byte[] lpBuffer,
        //int nNumberOfBytesToWrite,
        //ref int lpNumberOfBytesWritten,
        //IntPtr lpOverlapped);
        [StructLayout(LayoutKind.Sequential)]
        private struct COMSTAT
        {
            public uint uiCtsHold;
            public uint uiDsrHold;
            public uint uiRlsdHold;
            public uint uiXoffHold;
            public uint uiXoffSent;
            public uint uiEof;
            public uint uiTxim;
            public UInt32 uiFlags;
            public UInt32 cbInQue;
            public UInt32 cbOutQue;
        }

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        private static extern int ClearCommError(SafeFileHandle hFile, out UInt32 lpErrors, out COMSTAT lpStat)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        private static extern int FlushFileBuffers(SafeFileHandle hFile)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern bool ClearCommBreak(SafeFileHandle hFile)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", SetLastError = true)]
        internal static extern bool EscapeCommFunction(SafeFileHandle hFile, // handle to communications device
 int dwFunc // extended function to perform
        )
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern bool SetupComm(SafeFileHandle hFile, // handle to communications device
 int dwInQueue, // size of input buffer
 int dwOutQueue // size of output buffer
        )
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct DCB
        {
            public UInt32 DCBlength; /* sizeof(DCB)                     */
            public UInt32 BaudRate; /* Baudrate at which running       */
            public UInt32 fBinary; /* Binary Mode (skip EOF check)    */
            public UInt32 fParity; /* Enable parity checking          */
            public UInt32 fOutxCtsFlow; /* CTS handshaking on output       */
            public UInt32 fOutxDsrFlow; /* DSR handshaking on output       */
            public UInt32 fDtrControl; /* DTR Flow control                */
            public UInt32 fDsrSensitivity; /* DSR Sensitivity              */
            public UInt32 fTXContinueOnXoff; /* Continue TX when Xoff sent */
            public UInt32 fOutX; /* Enable output X-ON/X-OFF        */
            public UInt32 fInX; /* Enable input X-ON/X-OFF         */
            public UInt32 fErrorChar; /* Enable Err Replacement          */
            public UInt32 fNull; /* Enable Null stripping           */
            public UInt32 fRtsControl; /* Rts Flow control                */
            public UInt32 fAbortOnError; /* Abort all reads and writes on Error */
            public UInt32 fDummy2; /* Reserved                        */
            public UInt16 wReserved; /* Not currently used              */
            public UInt16 XonLim; /* Transmit X-ON threshold         */
            public UInt16 XoffLim; /* Transmit X-OFF threshold        */
            public byte ByteSize; /* Number of bits/byte, 4-8        */
            public byte Parity; /* 0-4=None,Odd,Even,Mark,Space    */
            public byte StopBits; /* 0,1,2 = 1, 1.5, 2               */
            public char XonChar; /* Tx and Rx X-ON character        */
            public char XoffChar; /* Tx and Rx X-OFF character       */
            public char ErrorChar; /* Error replacement char          */
            public char EofChar; /* End of Input character          */
            public char EvtChar; /* Received Event character        */
            public UInt16 wReserved1; /* Fill for now.                   */
        }

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        private static extern int GetCommState(SafeFileHandle hFile, out DCB lpDCB)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        //[DllImport("kernel32.dll", SetLastError = true)]
        //private static extern bool ReadFile(SafeFileHandle hFile, byte[] lpBuffer, int nNumberOfBytesToRead, ref int lpNumberOfBytesRead, IntPtr lpOverlapped);
        [DllImport("Kernel32.dll", SetLastError = true)]
        unsafe internal static extern bool ReadFile(SafeFileHandle handle, byte* bytes, int numBytesToRead, out int numBytesRead, IntPtr overlapped)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        private static extern int SetCommState(SafeFileHandle hFile, ref DCB lpDCB)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        private struct COMMTIMEOUTS
        {
            public long ReadIntervalTimeout; /* Maximum time between read chars. */
            public long ReadTotalTimeoutMultiplier; /* Multiplier of characters.        */
            public long ReadTotalTimeoutConstant; /* Constant in milliseconds.        */
            public long WriteTotalTimeoutMultiplier; /* Multiplier of characters.        */
            public long WriteTotalTimeoutConstant; /* Constant in milliseconds.        */
        }

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        private static extern int SetCommTimeouts(SafeFileHandle hFile, ref COMMTIMEOUTS lpCommTimeouts)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}