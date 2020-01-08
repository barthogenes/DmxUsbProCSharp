using System;
using System.Collections.Generic;
using DmxUsbProCSharp.Ftdi;

namespace DmxUsbProCSharp
{
	public interface IFtdiDriver : IDisposable
	{
		bool IsOpened();
		List<FTDI.FT_DEVICE_INFO_NODE> GetDevicesList();
		bool OpenDevice();
		string GetDriverVersion();
		int GetLatencyTimer();
		bool SetBaudRate(uint baudRate);
		bool SetTimeouts(uint readTimeout, uint writeTimeout);
		bool Reload();
		bool PurgeWriteBuffer();
		bool Write(byte[] data);
		bool PurgeReadBuffer();
		bool Read(byte[] data);
	}
}