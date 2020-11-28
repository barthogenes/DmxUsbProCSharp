using System;

namespace DmxUsbProCSharp.Enttec.Message
{
	public class ProParameters : EnttecMessageBody
	{
		public ProParameters(byte[] bodyBytes) : base(bodyBytes)
		{
			var dataLength = bodyBytes.Length;
			if (dataLength != 5)
				throw new ArgumentException("Parameter byte array of incorrect size!");
		}

		public string GetFirmwareVersion()
		{
			return $"{Data[1]}.{Data[0]}";
		}

		public int GetBreakTimeInMicroSeconds()
		{
			return (int)(Data[2] * 10.67 + 100);
		}

		public int GetMabTimeInMicroSeconds()
		{
			return (int)(Data[2] * 10.67);
		}

		public int GetSendRefreshRateInPacketsPerSecond()
		{
			return Data[2];
		}
	}
}
