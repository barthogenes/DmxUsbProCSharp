using DmxUsbProCSharp;
using System;
using System.Runtime.InteropServices;

namespace DmxUsbProCSharp.Ftdi
{
	public abstract class PlatformSpecific_FTD2XX_NET
	{
		private readonly bool IsLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
		private readonly string LinuxDriver = @"libftd2xx.so";
		private readonly string WindowsDriver = @"FTD2XX.DLL";

		protected IntPtr LoadLibrary()
		{
			if (IsLinux)
				return LinuxLibLoader.dlopen(LinuxDriver, LinuxLibLoader.RTLD_NOW);

			return WindowsLibLoader.LoadLibrary(WindowsDriver);
		}

		protected IntPtr GetProcAddress(IntPtr hModule, string procedureName)
		{
			if (IsLinux)
				return LinuxLibLoader.dlsym(hModule, procedureName);

			return WindowsLibLoader.GetProcAddress(hModule, procedureName);
		}

		protected bool FreeLibrary(IntPtr hModule)
		{
			if (IsLinux)
				return true;

			return WindowsLibLoader.FreeLibrary(hModule);
		}
	}
}
