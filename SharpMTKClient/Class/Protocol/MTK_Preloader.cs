using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.Protocol
{
    public struct PreloaderInfo
    {
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string FilePath;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public byte[] data;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public bool IsValidate;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string Platform;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string EMI_NAME;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string Project;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string EMI_VERSION;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public PlreloaderVersion version;
    }

    public enum PlreloaderVersion : int
    {
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        v1 = 1,
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        v2 = 2
    }

    public static class MTK_Preloader
    {
        public static string GetPreloaderPath
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

        public static string[] GetPreloaders
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

        public static string GenerateScatter(string Platform, string preloadername, string version, string projectname)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static PreloaderInfo GetInfo(byte[] PreloaderArray)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static PreloaderInfo GetInfo(string FileName)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}