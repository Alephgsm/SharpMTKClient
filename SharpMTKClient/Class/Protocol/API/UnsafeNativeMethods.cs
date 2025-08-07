using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MediatekNaiveProtocol.Mediatek.API
{
    public class UnsafeNativeMethods
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetDllDirectory(string lpPathName)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int GetDllDirectory(int bufsize, StringBuilder buf)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr LoadLibrary(string librayName)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("mylibrary")]
        public static extern void InitMyLibrary()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryEx", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadLibraryEx(string dllToLoad, IntPtr hFile, LoadLibraryFlags flags)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [System.Flags]
        public enum LoadLibraryFlags : uint
        {
            None = 0,
            DONT_RESOLVE_DLL_REFERENCES = 0x00000001,
            LOAD_IGNORE_CODE_AUTHZ_LEVEL = 0x00000010,
            LOAD_LIBRARY_AS_DATAFILE = 0x00000002,
            LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 0x00000040,
            LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x00000020,
            LOAD_WITH_ALTERED_SEARCH_PATH = 0x00000008,
            LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR = 0x00000100,
            LOAD_LIBRARY_SEARCH_SYSTEM32 = 0x00000800,
            LOAD_LIBRARY_SEARCH_DEFAULT_DIRS = 0x00001000
        }
    }
}