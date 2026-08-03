# Update History

Public SharpMTKClient update highlights are kept here so the README remains compact.

The public product page was created on **2022.01.13**. Early entries are summarized from the original product positioning, while newer entries list the public update notes that were published later.

## 2022.01.13

* Public SharpMTKClient product page created.
* Introduced SharpMTKClient as a C# Windows GUI source-code project for MediaTek chipset devices.
* Positioned the project as a private commercial source-code package for developers and software owners.
* Documented Windows API based USB protocol handling with no UsbDk dependency.
* Documented libusb usage only for selected `ControlTransfer` paths.
* Presented core MTK service goals: BROM / Preloader communication, DA workflows, firmware flashing, partition operations and device servicing.
* Listed early protocol focus for MediaTek bootrom and preloader workflows.
* Published early code and interface screenshots for the source-code product.

## 2022 - 2024

* Continued private development of the C# MTK protocol codebase.
* Expanded device workflow coverage across supported MediaTek chipsets and brands.
* Continued development around flash, partition, GPT, preloader, NV, RPMB, bootloader and hardware key paths.
* Maintained the project as a private source-code product instead of a public full-source repository.

## 2025.04.06

* Added native MTKV6 firmware flash through `flash.xml` and scatter.
* Updated legacy protocol.
* Fixed and optimized protocol areas.

## 2025.04.12

* Added read RPMB for V6 devices.
* Added write RPMB for V6 devices.
* Added native XML firmware write paths: download, firmware upgrade and download-only.
* Added flash partition by name for XML and XFLASH.
* Updated DA2 patch.
* Updated CPU list.
* Updated MTKV6 protocol.

## 2025.06.07

* Updated RPMB erase and write paths.
* Added vendor selection tab.
* Added selected Samsung, Motorola, Infinix, Honor, Vivo, Redmi and TCL workflow examples.
* Updated MTKV6 commands.

## 2025.09.23

* Added native C# EXT4 stream reader and writer paths.
* Added EXT4 partition mount and file / directory listing.
* Added logical partition and `super.img` browsing paths.
* Added EXT4 item extraction from logical partitions.
* Added replace, delete and add file workflows for EXT4.
* Added EXT4 partition detection.
* Added `build.prop` parser from system or super partition.

## 2025.10.23

* Added Carbonara exploit in universal mode for selected supported devices.
* Added new keys for `handle_sla` paths.
* Added `build.prop` information read in supported features.
* Updated MTKV6 protocol.
* Fixed and optimized protocol areas.

## 2025.10.27

* Added EROFS partition support paths.
* Added F2FS partition support paths.
* Added raw and sparse image handling from device and file.
* Optimized and fixed protocol issues.

## 2025.12.25

* Added partition explorer for EROFS, F2FS and EXT4FS.
* Updated EROFS algorithm.
* Added rename, replace, delete and copy-to-local workflows inside readable partitions.
* Updated other protocol areas.

## 2026.02.10

* Added HeapBait exploit workflow.
* Added selected Infinix chipset support paths for DA + exploit workflows.
* Added new key paths for Motorola, Xiaomi and AOT.
* Optimized and fixed XML protocol issues.

## 2026.02.13

* Added read IMEI info from device in all operations from `nvdata` and `ld0b`.
* Added decrypt NV items.
* Added IMEI repair for IMEI1 / IMEI2 in FlashMode.
* Added universal and Samsung MT67xx key paths where supported.
* Added Mi Account disable paths through system, APK and hosts methods.
* Added permanent bootloader unlock.

## 2026.02.21

* Added patch cert.
* Added IMEI Repair for selected Vivo, Xiaomi, OPPO, Infinix, Tecno and Itel targets.
* Added remove Payjoy.
* Added reset Huawei ID.
* Added reset OPPO ID.
* Added fix no efuse state.
* Added fix DM corrupted.
* Added remove security plugin.
* Added OTA Remove for OPPO, Realme and OnePlus.
* Added Xiaomi OTA Remove.
* Added MDM + OTA Remove.
* Added MDM / Walock Remove for Walton.
* Added SIM Lock / MDM Remove for Nothing / CMF.
* Added Xiaomi anti-relock modem patch.
* Added Persist Patch.
* Added Demo Remove.
* Added Payjoy Remove through selected `oeminfo` paths.
* Added IT Admin / Network / Payjoy Unlock.
* Added Restore Vbmeta for Security ON paths.
* Added Vbmeta Patch V1 / V2 / V3 for Security OFF paths.
* Added Mi Account + Global through `cust` / `opcust` paths.
* Added Mi Account Remove + Convert Global V2.
* Updated HeapBait protocol.
* Optimized protocol.

## 2026.04.26

* Synced and improved key protocol handling across recent device workflows.
* Added basic SSR crypto integration with optional Universal Config enablement and manual `ssr_base` entry; chipset configuration does not include `ssr_base` addresses yet, so users must enter the address manually.
* Added SSR key generation paths to Read Keys for RPMB, RPMB2, FDE and Motorola keys where supported.
* Updated XML and XFLASH response handling, including DA log message processing and stricter command-end error reporting.
* Reworked DA2 patching logic toward string-based function discovery for newer MTK DA2 payloads.
* Added Motorola / lamu SLA handling and improved SLA / DL forbidden error reporting.
* Updated MTK chip configuration data, including MT6880 / MT6890 modem, MT6878, MT6583 and selected legacy targets.
* Improved SEJ V3 hardware-code coverage and renamed updated HACC security-init register mappings.
* Improved HeapBait pointer-auth handling and ARM / AArch64 helper detection.
* Added safer GPT and partition-name handling to prevent null-name lookup failures.
* Added runtime log-channel selection support for UART, USB and combined DA logging paths.


## 2026.08.03

* added Motorola Direct IMEI repair (works on all MTK 4G Motorola devices)
* added Motorola Unlock Network
* patching IMEI records, backup records, network identity, carrier config, device identity
* ext4-based universal method, no per-device profile needed
* tested models: Moto E15, G05, G06, G15, G17
