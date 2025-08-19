
# C# SharpMTKClient, mtk chipset protocol
This is only skelet of SharpMTKClient for make trust no main source code. for getting main source code you have contact us

# About Source code
SharpMTKClient is GUI written with c# by alephgsm team for mediatek chipset devices, codes of this project are updated more often than bkerler/mtkclient and some forensic tools, but with continuous tests, we will fix some bugs. Also, this project is raw C# code and has no dependency on python, usbdk, etc.

SharpMTKClient also will support MTK V6 XML type device, you can see screenshots following screenshot list

usb protocol is based on windows api(kernel32) (No dependency on usbdk), we used libusb just for SLA bypass function

tested on 1000+ more device like xiomi, oppo , samsung , huawei, etc and all features will work w/o bugs

# Lasted updated:
* 2025.08.06

# whats news?
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
