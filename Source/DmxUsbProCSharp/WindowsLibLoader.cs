using System;
using System.Runtime.InteropServices;

namespace DmxUsbProCSharp
{
	public class WindowsLibLoader
	{
		/// <summary>
		/// Built-in Windows API functions to allow us to dynamically load our own DLL.
		/// Will allow us to use old versions of the DLL that do not have all of these functions available.
		/// </summary>
		[DllImport("kernel32.dll")]
		public static extern IntPtr LoadLibrary(string dllToLoad);
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);
		[DllImport("kernel32.dll")]
		public static extern bool FreeLibrary(IntPtr hModule);
	}
}
