
# C# SharpMTKClient, mtk chipset protocol
This is only skelet of SharpMTKClient for make trust no main source code. for getting main source code you have contact us

# About Source code
SharpMTKClient is GUI written with c# by alephgsm team for mediatek chipset devices, codes of this project are updated more often than bkerler/mtkclient and some forensic tools, but with continuous tests, we will fix some bugs. Also, this project is raw C# code and has no dependency on python, usbdk, etc.

SharpMTKClient also will support MTK V6 XML type device, you can see screenshots following screenshot list

usb protocol is based on windows api(kernel32) (No dependency on usbdk), we used libusb just for SLA bypass function

tested on 1000+ more device like xiomi, oppo , samsung , huawei, etc and all features will work w/o bugs

# whats news?
2025.10.27
```
- added support EROFS type partitions
- added support F2FS partition
- added support Raw, Sparse image (from device, from file)
- optimize and fixed some bugs
```
example log:
```
Hold boot key And Connect To PC (power off mode)
Waiting for mediatek port (Timeout 3 minute) :Ok
brom service detected
Handshake device :Ok
Reading device Info :OkOk
Mediatek XFlash Detected!
CPU Info :MT6768/MT6769 MT6768 (Helio G70/G80/G85)
disabling WatchDog Timer : Ok
Hardware Sub Code :0x8a00
Hardware Code :0x707
Hardware Version :0xca00
Software Version :0x00
Is Secure boot :True
Serial Link authorization Protect :True
download agent authorization Protect :True
SWJTAG enabled:True
EPP_PARAM at 0x600 after EMMC_BOOT/SDMMC_BOOT:False
Root cert required:True
Mem read auth:True
Mem write auth:True
Cmd 0xC8 blocked:True
ME_ID:0x1B1A97BD943F10FE97AC3D8E0F69B843
SOCID:0xD597C6EF5EA660011AF11AED38CE555DE1461C227FF618C5C195E8432FF48DF7
Disabling Watchdog timer :Ok
Sending payload : Ok
Trying disable SLA\DAA Kamakiri : Ok
Reading Preloader from device :Ok
Choosing the right da :Ok
Receiving EMI:Ok
Writing download agent :Ok
Jumping Download Agent :Ok
Sync signal :Ok
Setup environment :Ok
Setup param :Ok
Connection Status :brom mode
Sending emi :Ok
uploading stage 2: Ok
Adding DA Extensions: 
 ▶ Finding target to read info
    • product      :  283.21 MB   [EXT4]
    • system       :  1017.91 MB  [EXT4]
    • vendor       :  353.36 MB   [EXT4]
 ▶ Android OS Info
  • OEM          : Xiaomi
  • Model        : merlin
  • Name         : merlin
  • Product      : merlin
  • SDK Ver      : 29
  • Code Name    : REL
  • Incremental  : 258
  • Build ID     : QP1A.190711.020
  • Android Ver  : 10
  • Security Ver : 2019-12-05
  • CPU ABI      : arm64-v8a
  • Build Date   : Wed May 13 12:41:51 CST 2020
  • Fingerprint  : merlin-userdebug 10 QP1A.190711.020 258 test-keys
Reading Partition Information tables from device :Ok
Operation: Read Partitions
Elapsed time: 00:00:58
```
2025.10.23
```

Added carbonara exploit in universal mode (supported devices like motorola g24)

Added new keys for handle_sla function
Added read buildprop info in all features (devices with ext4 type(system, super), ERofs isno support yet)
Updated mtkv6 protocol
A lot bug fixed and optimized
```
2025.09.23
```
1- mount ext4 partition and get list of files, directory (with details like modified date, uid , gid , etc)
2- mount LP partition like "super.img"
3- mount ext4 item from LP partition like "system" that exist inside "super.img"
4- extract and dump file or directory item from ext4 partition
5- replace file item in ext4 partition
6- delete file from ext4 partition
7- add new file in ext4 partition
8- detect ext4 partitions 
9- add build prop parser from system or super partition
10 - ETC
```
2025.06.07
```
 1. updated RPMB Function (Erase, write)
 2 .add "vendor select tab" to select manufacturer and device
 3. support this device list (Handle sla, DA, etc):
  SAMSUNG [SM-A155F, SM-A155M, SM-A156U, SM-A156E, SM-A156B,
 SM-A245F, SM-A166P, SM-A165F, SM-A226B, SM-A245M, SM-X920F,
 SM-X820F, SM-X826B, SM-X926B, SM-X110, SM-X115, SM-G556B]

 MOTOROLA [MTKV5 [MT6768, MT6765] , MTKV6[MT6789, MT6855]]

 INFINIX [MTKV5, MTKV6]
 HONOR [v5 2025]
 VIVO [v5 2025]
 REDMI [13]
 TCL [T430M, t430w, t602, t607,t608, t609]
 4. Updated MTKV6 CMDs
```
# Features:
* auto detect mtk devices from pid&vid (usb plug , unplug event, no in while)
* Device type "XML, dalegacy , Xflash" Supported
* Supprted UFS, NAND, EMMC 
* auto bypass SLA & DAA
* crash preloader
* Flash (mtkv5 and mtkv6) (flash.xml, scatter) (native, flashtoollib api)
* read hardware keys
* Flash raw firmware
* Read Partition tables(gpt)
* Flash GPT
* rebuild GPT
* dump (backup) partitions
* read preloader
* flash preloader
* Erase partitions
* safe format
* manual format
* erase frp
* backup , write , erase nv partitions
* bootloader unlock/ relock
* fix read/orange error after bootloader unlock
* rpmb read/write/erase
* rpmb read key
* read hw keys
* DA/Preloader parser
* many more useful function exist in project codes ....



# Screenshots from Interface:
* Features :

![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/Screenshot-2025-04-12-072713.png)
* Flash :

![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/Screenshot-2025-04-12-072352.png)

* Partition Managment :

![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/Screenshot-2025-04-12-072739.png)

To Get source code of this project:
https://alephgsm.com/2022/01/13/csharp-mtkclient/
