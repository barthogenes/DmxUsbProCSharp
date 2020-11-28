using System;

namespace DmxUsbProCSharp.Enttec.Message
{
	public class EnttecMessageBody
	{
		public readonly byte[] Data;

		public EnttecMessageBody(byte[] bodyBytes)
		{
			var dataLength = bodyBytes.Length;
			if (dataLength < 1 || dataLength > 600)
				throw new ArgumentException("Body should be between 1 and 600 bytes!");

			Data = bodyBytes;
		}
	}
}
