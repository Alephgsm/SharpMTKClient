using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpMTKClient.Class.Protocol.Native
{
    public class gpt
    {
        public enum efi_type : uint
        {
            [Description("EFI_UNUSED")]
            EFI_UNUSED = 0x00000000,
            [Description("EFI_MBR")]
            EFI_MBR = 0x024DEE41,
            [Description("EFI_SYSTEM")]
            EFI_SYSTEM = 0xC12A7328,
            [Description("EFI_BIOS_BOOT")]
            EFI_BIOS_BOOT = 0x21686148,
            [Description("EFI_IFFS")]
            EFI_IFFS = 0xD3BFE2DE,
            [Description("EFI_SONY_BOOT")]
            EFI_SONY_BOOT = 0xF4019732,
            [Description("EFI_LENOVO_BOOT")]
            EFI_LENOVO_BOOT = 0xBFBFAFE7,
            [Description("EFI_MSR")]
            EFI_MSR = 0xE3C9E316,
            [Description("EFI_BASIC_DATA")]
            EFI_BASIC_DATA = 0xEBD0A0A2,
            [Description("EFI_LDM_META")]
            EFI_LDM_META = 0x5808C8AA,
            [Description("EFI_LDM")]
            EFI_LDM = 0xAF9B60A0,
            [Description("EFI_RECOVERY")]
            EFI_RECOVERY = 0xDE94BBA4,
            [Description("EFI_GPFS")]
            EFI_GPFS = 0x37AFFC90,
            [Description("EFI_STORAGE_SPACES")]
            EFI_STORAGE_SPACES = 0xE75CAF8F,
            [Description("EFI_HPUX_DATA")]
            EFI_HPUX_DATA = 0x75894C1E,
            [Description("EFI_HPUX_SERVICE")]
            EFI_HPUX_SERVICE = 0xE2A1E728,
            [Description("EFI_LINUX_DAYA")]
            EFI_LINUX_DAYA = 0x0FC63DAF,
            [Description("EFI_LINUX_RAID")]
            EFI_LINUX_RAID = 0xA19D880F,
            [Description("EFI_LINUX_ROOT32")]
            EFI_LINUX_ROOT32 = 0x44479540,
            [Description("EFI_LINUX_ROOT64")]
            EFI_LINUX_ROOT64 = 0x4F68BCE3,
            [Description("EFI_LINUX_ROOT_ARM32")]
            EFI_LINUX_ROOT_ARM32 = 0x69DAD710,
            [Description("EFI_LINUX_ROOT_ARM64")]
            EFI_LINUX_ROOT_ARM64 = 0xB921B045,
            [Description("EFI_LINUX_SWAP")]
            EFI_LINUX_SWAP = 0x0657FD6D,
            [Description("EFI_LINUX_LVM")]
            EFI_LINUX_LVM = 0xE6D6D379,
            [Description("EFI_LINUX_HOME")]
            EFI_LINUX_HOME = 0x933AC7E1,
            [Description("EFI_LINUX_SRV")]
            EFI_LINUX_SRV = 0x3B8F8425,
            [Description("EFI_LINUX_DM_CRYPT")]
            EFI_LINUX_DM_CRYPT = 0x7FFEC5C9,
            [Description("EFI_LINUX_LUKS")]
            EFI_LINUX_LUKS = 0xCA7D7CCB,
            [Description("EFI_LINUX_RESERVED")]
            EFI_LINUX_RESERVED = 0x8DA63339,
            [Description("EFI_FREEBSD_BOOT")]
            EFI_FREEBSD_BOOT = 0x83BD6B9D,
            [Description("EFI_FREEBSD_DATA")]
            EFI_FREEBSD_DATA = 0x516E7CB4,
            [Description("EFI_FREEBSD_SWAP")]
            EFI_FREEBSD_SWAP = 0x516E7CB5,
            [Description("EFI_FREEBSD_UFS")]
            EFI_FREEBSD_UFS = 0x516E7CB6,
            [Description("EFI_FREEBSD_VINUM")]
            EFI_FREEBSD_VINUM = 0x516E7CB8,
            [Description("EFI_FREEBSD_ZFS")]
            EFI_FREEBSD_ZFS = 0x516E7CBA,
            [Description("EFI_OSX_HFS")]
            EFI_OSX_HFS = 0x48465300,
            [Description("EFI_OSX_UFS")]
            EFI_OSX_UFS = 0x55465300,
            [Description("EFI_OSX_ZFS")]
            EFI_OSX_ZFS = 0x6A898CC3,
            [Description("EFI_OSX_RAID")]
            EFI_OSX_RAID = 0x52414944,
            [Description("EFI_OSX_RAID_OFFLINE")]
            EFI_OSX_RAID_OFFLINE = 0x52414944,
            [Description("EFI_OSX_RECOVERY")]
            EFI_OSX_RECOVERY = 0x426F6F74,
            [Description("EFI_OSX_LABEL")]
            EFI_OSX_LABEL = 0x4C616265,
            [Description("EFI_OSX_TV_RECOVERY")]
            EFI_OSX_TV_RECOVERY = 0x5265636F,
            [Description("EFI_OSX_CORE_STORAGE")]
            EFI_OSX_CORE_STORAGE = 0x53746F72,
            [Description("EFI_SOLARIS_BOOT")]
            EFI_SOLARIS_BOOT = 0x6A82CB45,
            [Description("EFI_SOLARIS_ROOT")]
            EFI_SOLARIS_ROOT = 0x6A85CF4D,
            [Description("EFI_SOLARIS_SWAP")]
            EFI_SOLARIS_SWAP = 0x6A87C46F,
            [Description("EFI_SOLARIS_BACKUP")]
            EFI_SOLARIS_BACKUP = 0x6A8B642B,
            [Description("EFI_SOLARIS_USR")]
            EFI_SOLARIS_USR = 0x6A898CC3,
            [Description("EFI_SOLARIS_VAR")]
            EFI_SOLARIS_VAR = 0x6A8EF2E9,
            [Description("EFI_SOLARIS_HOME")]
            EFI_SOLARIS_HOME = 0x6A90BA39,
            [Description("EFI_SOLARIS_ALTERNATE")]
            EFI_SOLARIS_ALTERNATE = 0x6A9283A5,
            [Description("EFI_SOLARIS_RESERVED1")]
            EFI_SOLARIS_RESERVED1 = 0x6A945A3B,
            [Description("EFI_SOLARIS_RESERVED2")]
            EFI_SOLARIS_RESERVED2 = 0x6A9630D1,
            [Description("EFI_SOLARIS_RESERVED3")]
            EFI_SOLARIS_RESERVED3 = 0x6A980767,
            [Description("EFI_SOLARIS_RESERVED4")]
            EFI_SOLARIS_RESERVED4 = 0x6A96237F,
            [Description("EFI_SOLARIS_RESERVED5")]
            EFI_SOLARIS_RESERVED5 = 0x6A8D2AC7,
            [Description("EFI_NETBSD_SWAP")]
            EFI_NETBSD_SWAP = 0x49F48D32,
            [Description("EFI_NETBSD_FFS")]
            EFI_NETBSD_FFS = 0x49F48D5A,
            [Description("EFI_NETBSD_LFS")]
            EFI_NETBSD_LFS = 0x49F48D82,
            [Description("EFI_NETBSD_RAID")]
            EFI_NETBSD_RAID = 0x49F48DAA,
            [Description("EFI_NETBSD_CONCAT")]
            EFI_NETBSD_CONCAT = 0x2DB519C4,
            [Description("EFI_NETBSD_ENCRYPT")]
            EFI_NETBSD_ENCRYPT = 0x2DB519EC,
            [Description("EFI_CHROMEOS_KERNEL")]
            EFI_CHROMEOS_KERNEL = 0xFE3A2A5D,
            [Description("EFI_CHROMEOS_ROOTFS")]
            EFI_CHROMEOS_ROOTFS = 0x3CB8E202,
            [Description("EFI_CHROMEOS_FUTURE")]
            EFI_CHROMEOS_FUTURE = 0x2E0A753D,
            [Description("EFI_HAIKU")]
            EFI_HAIKU = 0x42465331,
            [Description("EFI_MIDNIGHTBSD_BOOT")]
            EFI_MIDNIGHTBSD_BOOT = 0x85D5E45E,
            [Description("EFI_MIDNIGHTBSD_DATA")]
            EFI_MIDNIGHTBSD_DATA = 0x85D5E45A,
            [Description("EFI_MIDNIGHTBSD_SWAP")]
            EFI_MIDNIGHTBSD_SWAP = 0x85D5E45B,
            [Description("EFI_MIDNIGHTBSD_UFS")]
            EFI_MIDNIGHTBSD_UFS = 0x0394EF8B,
            [Description("EFI_MIDNIGHTBSD_VINUM")]
            EFI_MIDNIGHTBSD_VINUM = 0x85D5E45C,
            [Description("EFI_MIDNIGHTBSD_ZFS")]
            EFI_MIDNIGHTBSD_ZFS = 0x85D5E45D,
            [Description("EFI_CEPH_JOURNAL")]
            EFI_CEPH_JOURNAL = 0x45B0969E,
            [Description("EFI_CEPH_ENCRYPT")]
            EFI_CEPH_ENCRYPT = 0x45B0969E,
            [Description("EFI_CEPH_OSD")]
            EFI_CEPH_OSD = 0x4FBD7E29,
            [Description("EFI_CEPH_ENCRYPT_OSD")]
            EFI_CEPH_ENCRYPT_OSD = 0x4FBD7E29,
            [Description("EFI_CEPH_CREATE")]
            EFI_CEPH_CREATE = 0x89C57F98,
            [Description("EFI_CEPH_ENCRYPT_CREATE")]
            EFI_CEPH_ENCRYPT_CREATE = 0x89C57F98,
            [Description("EFI_OPENBSD")]
            EFI_OPENBSD = 0x824CC7A0,
            [Description("EFI_QNX")]
            EFI_QNX = 0xCEF5A9AD,
            [Description("EFI_PLAN9")]
            EFI_PLAN9 = 0xC91818F9,
            [Description("EFI_VMWARE_VMKCORE")]
            EFI_VMWARE_VMKCORE = 0x9D275380,
            [Description("EFI_VMWARE_VMFS")]
            EFI_VMWARE_VMFS = 0xAA31E02A,
            [Description("EFI_VMWARE_RESERVED")]
            EFI_VMWARE_RESERVED = 0x9198EFFC
        }

        public class gpt_partition
        {
            public byte[] type;
            public byte[] unique;
            public ulong first_lba;
            public ulong last_lba;
            public ulong flags;
            public byte[] name;
            public gpt_partition(byte[] data)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }
        }

        public class gpt_header
        {
            public byte[] signature;
            public uint revision;
            public uint header_size;
            public uint crc32;
            public uint reserved;
            public ulong current_lba;
            public ulong backup_lba;
            public ulong first_usable_lba;
            public ulong last_usable_lba;
            public byte[] disk_guid;
            public ulong part_entry_start_lba;
            public uint num_part_entries;
            public uint part_entry_size;
            public gpt_header(byte[] data)
            {
                throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
            }
        }

        public List<partf> partentries = new List<partf>();
        public ulong totalsectors;
        public uint num_part_entries;
        public uint part_entry_size;
        public uint part_entry_start_lba;
        public gpt(uint num_part_entries = 0, uint part_entry_size = 0, uint part_entry_start_lba = 0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public struct partf
        {
            public int index;
            public string unique;
            public ulong first_lba;
            public ulong last_lba;
            public ulong flags;
            public ulong sector;
            public ulong sectors;
            public string type;
            public string name;
            public ulong size;
            public ulong start;
        }

        public gpt_header parseheader(byte[] gptdata, int sectorsize = 512)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public gpt_header header;
        public int sectorsize;
        public byte[] pack(byte[] gptdata, List<partf> partentries, uint part_entry_start_lba, ulong header_part_entry_start_lba, int sectorsize, uint header_part_entry_size, uint header_num_part_entries)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool parse(byte[] gptdata, int sectorsize = 512)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool parse_bpi(byte[] gptdata, int pagesize = 0x200)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}