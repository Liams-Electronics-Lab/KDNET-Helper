# KDNET-Helper
A Windows GUI tool to simplify kernel debugging setup using KDNET between two machines over the local network.

## Features

- Configure target machine for KDNET and generate debugging key
- Share key via temporary network share with automatic cleanup on next boot
- Retrieve key from target share and launch WinDbg with correct parameters


## Requirements

- Windows 10 or later (64-bit recommended)
- Administrator privileges (required for BCDEDIT and network share)
- [Windows SDK / Debugging Tools for Windows](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/) (for kdnet.exe and windbg.exe) or place redistributable files in `Redist\x64\` (kdnet.exe + VerifiedNICList.xml)
- .NET 8.0 Runtime

## Installation

1. Download the latest release or build from source:

   ```dotnet build -c release```

2. Run `KdnetHelper.exe` as Administrator (the app will auto-elevate if needed).

## Usage


<img width="2558" height="1393" alt="" src="https://github.com/user-attachments/assets/6460584d-55c1-4ced-a4bb-9165797bc505" />


### Target Machine (the system being debugged)

> Bitlocker and secureboot must be disabled on the target machine!

1. Enter the host machine's IP address and a port (recommended 50000-50039).
2. Click **Check NIC** to verify adapter compatibility.
3. Click **Enable KDNET** – the tool runs `kdnet.exe` and stores the generated key.
4. (Optional) Check **Share Key via Network** – creates a temporary share `\\target\KDNETHELPERKEY` with user `KDNETHELPER` / password `KdnetH1!`. The share and user are automatically removed on next boot.
5. Reboot the target to start kernel debugging.

### Host Machine (running WinDbg)

1. In the Host tab, note your local IP (reference only).
2. Enter the target machine's IP address and click **Fetch Key from Target** (uses the temporary share credentials).
``2a. Alternatively, manually copy they key from the target.``  
3. The key appears in the data grid – select it and click **Copy Selected Key** to fill the key field.
4. Ensure the port matches the target's port, then click **Launch WinDbg** to start the debugger.

### Disabling Debugging

On the target, click **Disable Debug** – this removes KDNET settings from BCD and disables kernel debugging. Reboot to return to normal operation.

## File Redistribution

To avoid requiring the Windows SDK, place the following files in the `Redist\x64\` folder (or `Redist\x86\` for 32-bit systems):

- `kdnet.exe`
- `VerifiedNICList.xml`

The tool will use these first.

## Links

Developed by Liams Electronics Lab  
YouTube: https://www.youtube.com/@Slot1Gamer  
GitHub: https://github.com/Liams-Electronics-Lab

