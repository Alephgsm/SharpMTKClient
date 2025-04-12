# C# SharpMTKClient, mtk chipset protocol
# About Source code
SharpMTKClient is GUI written with c# by alephgsm team for mediatek chipset devices, codes of this project are updated more often than bkerler/mtkclient and some forensic tools, but with continuous tests, we will fix some bugs. Also, this project is raw C# code and has no dependency on python, usbdk, etc.

SharpMTKClient also will support MTK V6 XML type device, you can see screenshots following screenshot list

usb protocol is based on windows api(kernel32) (No dependency on usbdk), we used libusb just for SLA bypass function

tested on 1000+ more device like xiomi, oppo , samsung , huawei, etc and all features will work w/o bugs

# Lasted updated:
* 2025.04.12

# Features:
* auto detect mtk devices from pid&vid (usb plug , unplug event, no in while)
* Device type "XML, dalegacy , Xflash" Supported
* Supprted UFS, NAND, EMMC & up to last cpu that support in bkerler/mtkclient prject
* auto bypass SLA & DAA
* crash preloader
* Flash (mtkv6, mtkv5) (native, flashtoollib api)
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

# Screenshots from Codes:
* Solution explorer:
  
![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/1-1.jpg)
* function for v6 device:
  
![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/2-1.jpg)
* function for v6 device:

![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/3-1.jpg)
* write function :

![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/4.jpg)
* readflash function :

![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/5.jpg)
* Sej function :

![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/6.jpg)

# Screenshots from Interface:
* Features :

![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/Screenshot-2025-04-12-072713.png)
* Flash :

![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/Screenshot-2025-04-12-072352.png)

* Partition Managment :

![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/Screenshot-2025-04-12-072739.png)

To Get source code of this project:
https://alephgsm.com/2022/01/13/csharp-mtkclient/
