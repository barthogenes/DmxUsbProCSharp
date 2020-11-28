using System;
using System.Runtime.InteropServices;

namespace DmxUsbProCSharp
{
	public class LinuxLibLoader
	{
		public const int RTLD_NOW = 0x002;
		[DllImport("libdl.so.2")]
		public static extern IntPtr dlopen(string libName, int flags);
		[DllImport("libdl.so.2")]
		public static extern IntPtr dlsym(IntPtr handle, string symbol);
	}
}
