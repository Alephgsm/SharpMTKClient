using SharpMTKClient.Class.Protocol.xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatekNaiveProtocol.Mediatek
{
    public static class XMLCmd
    {
        public const uint MAGIC = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static string cmd_notify_init_hw()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_set_host_info(string hostinfo = "")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string create_cmd(string cmd, Dictionary<string, List<string>> content = null, string version = "1.0")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_create(string cmd, Dictionary<string, List<string>> content = null, string version = "1.0")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_set_runtime_parameter(string checksum_level = "NONE", string battery_exist = "AUTO-DETECT", string da_log_level = "INFO", string log_channel = "UART", string system_os = "WINDOWS", string version = "1.1", bool initialize_dram = true)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_host_supported_commands(string host_capability = "CMD:DOWNLOAD-FILE^1@CMD:FILE-SYS-OPERATION^1@CMD:PROGRESS-REPORT^1@CMD:UPLOAD-FILE^1@")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_security_set_flash_policy(int host_offset = 0x8000000, int length = 0x100000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_boot_to(long at_addr = 0x40000000, long jmp_addr = 0x40000000, long host_offset = 0x7fe83c09a04c, int length = 0x50c78)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_ram_test(string function = "FLIP", int start_address = 0x4000000, int length = 0x100000, int repeat = 0xA)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_dram_repair(int mem_offset = 0x10000, int mem_length = 0x1000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_can_higher_usb_speed(long host_mem_offset = 0x7fe8463ed240, int length = 0x40)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_get_dev_info(int host_mem_offset = 0x8000000, int length = 0x100000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_get_hw_info(long host_mem_offset = 0x7fe83c138700, long length = 0x200000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_get_da_info(long host_mem_offset = 0x2000000, long length = 0x20000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_emmc_control(string function = "GET-RPMB-STATUS", long mem_offset = 0x7fe83c338710, long mem_length = 0x200000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_reboot(bool disconnect = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_write_flash(string partition = "EMMC-USER", ulong offset = 0, ulong mem_offset = 0x8000000, ulong mem_length = 0x100000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_write_flash_offset(string partition = "EMMC-USER", ulong offset = 0, ulong mem_offset = 0x8000000, ulong mem_length = 0x100000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_write_partitions(string partition = "system", long mem_offset = 0x8000000, long mem_length = 0x100000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_flash_update(string xml)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_flash_update(List<partitionaddr> partitions, string xml, string backup)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_flash_all(List<partitionaddr> partitions, string xml)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_write_partition(string partition = "SOS")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_write_partition(string partitions, string sourcedir = "C:\\test.bin")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string write_partitions(List<string> partitions, string source_file = "")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_read_partition_table(long host_mem_offset = 0x7fe83c538720, int length = 0x200000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_read_partition(string partition = "system", string location = "C:/file.bin")
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_read_partitions(string partition = "system", long mem_offset = 0x8000000, long mem_length = 0x100000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_get_downloaded_image_feedback(long mem_offset = 0x2000000, long mem_length = 0x20000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_read_flash(string partition = "EMMC-USER", ulong offset = 0, ulong length = 0x100000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_erase_flash(string partition = "EMMC-USER", ulong offset = 0, ulong length = 0x100000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_erase_all(string partition = "ALL", long offset = 0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string cmd_get_sys_property(string key = "DA.SLA", long host_mem_offset = 0x7fe83c138700, long length = 0x200000)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}