# C# SharpMTKClient, mtk chipset protocol
# About Source code
SharpMTKClient is GUI written with c# by alephgsm team for mediatek chipset devices, codes of this project are updated more often than bkerler/mtkclient and some forensic tools, but with continuous tests, we will fix some bugs. Also, this project is raw C# code and has no dependency on python, usbdk, etc.
SharpMTKClient also will support MTK V6 XML type device, you can see screenshots following screenshot list
usb protocol is based on windows api(kernel32) (No dependency on usbdk), we used libusb just for SLA bypass function

tested on 1000+ more device like xiomi, oppo , samsung , huawei, etc and all features will work w/o bugs

# Lasted updated :
* 2024/06/09

# Features
*auto detect mtk devices from pid&vid (usb plug , unplug event, no in while)
*Device type "XML, dalegacy , Xflash" Supported
*Supprted UFS, NAND, EMMC & up to last cpu that support in bkerler/mtkclient prject
*auto bypass SLA & DAA
*crash preloader
*Flash
*Flash raw firmware
*Read Partition tables(gpt)
*Flash GPT
*rebuild GPT
*dump (backup) partitions
*read preloader
*flash preloader
*Erase partitions
*safe format
*manual format
*erase frp
*backup , write , erase nv partitions
*bootloader unlock/ relock
*fix read/orange error after bootloader unlock
*rpmb read/write/erase
*rpmb read key
*DA/Preloader parser
*many more useful function exist in project codes ....

# Screenshots from Codes:
[![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/1-1.jpg)
[![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/2-1.jpg)
[![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/3-1.jpg)
[![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/4.jpg)
[![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/5.jpg)
[![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/6.jpg)

# Screenshots from Interface:
[![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/FeaturePage.jpg)
[![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/FlashPage.jpg)
[![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/ManualConfig.jpg)
[![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/NetworkPage.jpg)
[![SharpMTKClient](https://alephgsm.com/wp-content/uploads/2022/01/PartitionManagmet.jpg)


get source code of this project
https://alephgsm.com/2022/01/13/csharp-mtkclient/
