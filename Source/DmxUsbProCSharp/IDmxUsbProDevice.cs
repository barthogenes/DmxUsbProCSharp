using System;

namespace DmxUsbProCSharp
{
	public interface IDmxUsbProDevice : IDisposable
	{
		bool IsConnected();
		bool Connect();
		bool SetDmxOutput(byte[] dmxBytes);
		byte[] ReadDmxInput();
	}
}