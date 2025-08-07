using Newtonsoft.Json;
using SharpMTKClient.Class.Protocol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SharpMTKClient.Class.Protocol.Native.mtk_daxflash;

namespace SharpMTKClient.Class
{
    public enum Resut
    {
        Word,
        Success,
        Yellow,
        Error
    }

    public class DBConfig
    {
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public List<IOperation> Operations = new List<IOperation>();
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public ItypeConfig manualConfig;
        public static DBConfig CFG = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
    }

    public struct IRichItem
    {
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string text;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public Resut color;
    }

    public struct IOperation
    {
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public DateTime StartedAt, EndedAt;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public List<IRichItem> Items;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string OperationName, Tab;
    }

    public enum SLAType : int
    {
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        auto,
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        force,
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        skip
    }

    public enum DeviceMode
    {
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        universal,
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        VendorBase
    }

    public struct ItypeConfig
    {
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public DeviceMode mode;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string vendor;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string model;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string chip;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public SLAType SLADAA;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public bool PatchDA;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public bool CrashPL;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string preloader;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string auth;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string cert;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string da;
    }

    public static class util
    {
        public const string Version = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public delegate XreadFlashResult readflash(ulong addr, ulong len, string filename, string parttype = "");
        internal static bool stop = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static string MyPath
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

        public static byte[] Slice(byte[] array, int offset, int length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void ReplaceRange(ref byte[] array, int offset, int length, byte[] replacement)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string GetHex(long value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        => value.ToString("X");
        public static bool EndsWith(byte[] array, byte[] suffix)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static bool IsHexString(string input)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string Hex(uint Number)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static MediatekService config = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static bool Equals(byte[] source, byte[] separator, int index)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string TrimEnd(string input, string suffixToRemove)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] TrimEnd(byte[] data, byte item)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void BackupSettings()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void LoadDB()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string GetFileCalc(double len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static List<byte[]> SplitByteArray(byte[] array, byte delimiter)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[][] SplitByteArray(byte[] source, byte[] separator)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public delegate void LogDelegate(string text, Resut color = Resut.Word);
        public static ulong Hex(this string value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string Right(this string value, int length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static bool match(byte[] haystack, byte[] needle, int start)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static int search(byte[] haystack, byte[] needle, int index)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static bool IsNumeric(this string s)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void CreatFolder(string name)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] ReadBytes(Stream strm, int count)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] Cut(this byte[] data, int index, int len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static T ByteArrayToStructure<T>(byte[] bytes, ref int offset)
            where T : struct
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static object BytesToStuct(byte[] bytes, Type type)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] StructToBytes(object structObj, int length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string GetEnumDescription(Enum enumVal)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] StructToBytes<T>(T structure)
            where T : struct
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static IntPtr StructToPTR<T>(T structure)
            where T : struct
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static bool IsNumber(object value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] StringToByteArray(string hex)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] ToByte(this string hex)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static int GetLittleEndianIntegerFromByteArray(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static int GetLittleEndianIntegerFromByteArray(byte[] data, int startIndex)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] SHA256CheckSum(byte[] Array)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string GetBytesReadable(long i)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static int FindByteOffset(byte[] array, byte[] pattern, int offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static uint GetL32(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static int IndexOfSequence(List<byte> buffer, List<byte> pattern, int start = 0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static int findSequence(byte[] array, byte[] sequence, int start = 0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] qUncompress(byte[] compressedData)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private static readonly ushort[] crcTable = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static ushort qChecksum(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] SHA1CheckSum(byte[] Array)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] GetByteArray(byte[] bytesIn, int index, int length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void OpenFolderAndSelectFile(string filePath)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void OpenFolderAndSelectItem(string folderPath, string file)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [DllImport("shell32.dll", SetLastError = true)]
        public static extern int SHOpenFolderAndSelectItems(IntPtr pidlFolder, uint cidl, [In, MarshalAs(UnmanagedType.LPArray)] IntPtr[] apidl, uint dwFlags)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [DllImport("shell32.dll", SetLastError = true)]
        public static extern void SHParseDisplayName([MarshalAs(UnmanagedType.LPWStr)] string name, IntPtr bindingContext, [Out] out IntPtr pidl, uint sfgaoIn, [Out] out uint psfgaoOut)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        public static string BytesToHexString(byte[] byteInput)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string tohex(this byte[] byteInput)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static void Wait(int interval)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static int crc(int crc, byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string WinwcharToChar(ushort[] pBuf)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static int getUnsignedShort(byte b1, byte b0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static IEnumerable<int> Range(int start, int stop, int step = 1)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}