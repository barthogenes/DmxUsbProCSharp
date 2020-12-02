using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace DmxUsbProCSharp.Ftdi
{
	public class FtdiDriver : IFtdiDriver
	{
		private readonly FTDI ftdi;

		public FtdiDriver()
		{
			ftdi = new FTDI();
		}

		public virtual bool IsOpened()
		{
			return ftdi.IsOpen;
		}

		public virtual List<FTDI.FT_DEVICE_INFO_NODE> GetDevicesList()
		{
			var dList = new FTDI.FT_DEVICE_INFO_NODE[10];
			var devicesList = new List<FTDI.FT_DEVICE_INFO_NODE>();
			var result = ftdi.GetDeviceList(dList);
			if (result != FTDI.FT_STATUS.FT_OK)
				return devicesList;

			devicesList.AddRange(dList.Where(device => device != null).AsEnumerable());
			return devicesList;
		}

		public virtual bool OpenDevice()
		{
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
				return ftdi.OpenByIndex(0) == FTDI.FT_STATUS.FT_OK;

			var deviceList = GetDevicesList();
			var dmxUsbProDevice = deviceList.FirstOrDefault(d => d.Description != null && d.Description.Equals("DMX USB PRO"));
			return ftdi.OpenByLocation(dmxUsbProDevice.LocId) == FTDI.FT_STATUS.FT_OK;
		}

		public virtual string GetDriverVersion()
		{
			uint driverVersion = 0;
			if (ftdi.GetDriverVersion(ref driverVersion) != FTDI.FT_STATUS.FT_OK)
				return "";

			var majorVersion = (byte)driverVersion >> 16;
			var minorVersion = (byte)driverVersion >> 8;
			var buildVersion = (byte)driverVersion & 0xFF;

			return $"{majorVersion:X2}.{minorVersion:X2}.{buildVersion:X2}";
		}

		public virtual int GetLatencyTimer()
		{
			byte latency = 0;
			ftdi.GetLatency(ref latency);

			return latency;
		}

		public virtual bool SetBaudRate(uint baudRate)
		{
			var result = ftdi.SetBaudRate(115200);
			return result == FTDI.FT_STATUS.FT_OK;
		}

		public virtual bool SetTimeouts(uint readTimeout, uint writeTimeout)
		{
			var result = ftdi.SetTimeouts(120, 100);
			return result == FTDI.FT_STATUS.FT_OK;
		}

		public virtual bool Reload()
		{
			ushort wVID = 0x0403;
			ushort wPID = 0x6001;
			var status = ftdi.Reload(wVID, wPID);
			Thread.Sleep(3500);
			return status == FTDI.FT_STATUS.FT_OK;
		}

		public virtual bool PurgeWriteBuffer()
		{
			var status = ftdi.Purge(FTD2XX_NET.FTDI.FT_PURGE.FT_PURGE_TX);
			return status == FTDI.FT_STATUS.FT_OK;
		}

		public virtual bool Write(byte[] data)
		{
			uint bytesWritten = 0;
			var dataLength = data.Length;
			var status = ftdi.Write(data, dataLength, ref bytesWritten);
			return status == FTDI.FT_STATUS.FT_OK && bytesWritten == dataLength;
		}

		public virtual bool PurgeReadBuffer()
		{
			var status = ftdi.Purge(FTD2XX_NET.FTDI.FT_PURGE.FT_PURGE_RX);
			return status == FTDI.FT_STATUS.FT_OK;
		}

		public virtual bool Read(byte[] data)
		{
			uint bytesRead = 0;
			var expectedLength = (uint)data.Length;
			var status = ftdi.Read(data, expectedLength, ref bytesRead);
			return status == FTDI.FT_STATUS.FT_OK && bytesRead == expectedLength;
		}

		public virtual void Dispose()
		{
			if (!ftdi.IsOpen)
				return;

			ftdi.Close();
		}
	}
}
